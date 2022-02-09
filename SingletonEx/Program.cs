using System;
using System.Threading.Tasks;

namespace SingletonEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating singleton objects
            Singleton s1 = Singleton.GetInstance;
            s1.printmessage("i am singleton1");

            Singleton s2 = Singleton.GetInstance;
            s2.printmessage("I am Singleton2");

            //Creating Singleton Multithread objects
            Parallel.Invoke(
                () => PrintMethod1(),
                ()=>PrintMethod2()
                );          

        }

        private static void PrintMethod2()
        {
            SingletonMultithread SM2 = SingletonMultithread.GetInstance;
            SM2.print("I am Singleton multithread 2");
        }

        private static void PrintMethod1()
        {
            SingletonMultithread SM1 = SingletonMultithread.GetInstance;
            SM1.print("I am Singleton Multithread 1");
        }
    }
}
