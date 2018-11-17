using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Singleton.SixthVersion
{
    //USING LAZY<T> TYPE
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy =
            new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance { get { return lazy.Value; } }

        private Singleton()
        {
        }
    }
}
