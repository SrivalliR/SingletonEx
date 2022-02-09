using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonEx
{
    //singleton = single object for single thread environment
    class Singleton
    {
        private static int counter = 0;
        public static Singleton singleton=null;
        public static Singleton GetInstance
        { 
            get
            {
                if(singleton is null)
                {
                    singleton = new Singleton();
                }
                return singleton;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("obj " + counter);
        }
        public void printmessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
