using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.FourthVersion
{
    //THREAD - SAFE WITHOUT USING LOCKS
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        static Singleton()
        {
        }

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
