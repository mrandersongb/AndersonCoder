using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonPattern singletonPattern1 = SingletonPattern.Instance();

            SingletonPattern singletonPattern2 = SingletonPattern.Instance();

            if(singletonPattern1.Equals(singletonPattern2))
            {
                Console.WriteLine("singletonPattern1 is equal singlePattern2");
            }

            if (singletonPattern1 == singletonPattern2)
            {
                Console.WriteLine("singletonPattern1 is equal singlePattern2");
            }
        }
    }
}
