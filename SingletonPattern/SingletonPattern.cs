using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    /// <summary>
    /// The 'Singleton' class example
    /// </summary>
    sealed class SingletonPattern
    {
        static readonly SingletonPattern instance = new SingletonPattern();

        public static SingletonPattern Instance()
        {
            return instance;
        }

        private SingletonPattern() { }
    }
}
