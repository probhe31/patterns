﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.FirstVersion
{
    //NOT THREAD SAFE
    public sealed class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
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
