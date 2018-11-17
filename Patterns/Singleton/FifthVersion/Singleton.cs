﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Singleton.FifthVersion
{
    //FULLY LAZY INSTANTIATION
    public sealed class Singleton
    {
        private Singleton()
        {
        }

        public static Singleton Instance { get { return Nested.instance; } }

        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly Singleton instance = new Singleton();
        }
    }
}
