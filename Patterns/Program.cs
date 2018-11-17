using System;

namespace Singleton
{
    using Singleton.ThirdVersion;
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.CallMe();
            Console.ReadKey();

        }
    }
}
