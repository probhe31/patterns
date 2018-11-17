using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Singleton.SecondVersion
{
    //SIMPLE THREAD - SAFETY
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }
}
