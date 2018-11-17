using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.ThirdVersion
{
    //THREAD-SAFE USING DOUBLE-CHECK LOCKING
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
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }

        public void CallMe()
        {
            Console.WriteLine("Hi Singleton");
        }
    }
}
