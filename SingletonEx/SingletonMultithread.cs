using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonEx
{
    //singleton = single object for multi thread environment
    class SingletonMultithread
    {
        private static int counter = 0;
        private static SingletonMultithread sss = null;
        private static object lockobject=new object();

        private static Lazy<SingletonMultithread> lazysingletonmultithread = 
            new Lazy<SingletonMultithread>(()=>new SingletonMultithread());
        public static SingletonMultithread  GetInstance {
            get
            {
                //if (sss is null)
                //{
                //    lock (lockobject)
                //    {
                //        if (sss is null)
                //        {
                //            sss = new SingletonMultithread();
                //        }

                //    }
                //}
                //return sss;

                return lazysingletonmultithread.Value;
            }
        }
        private SingletonMultithread()
        {
            counter++;
            Console.WriteLine("Obj " + counter);
        }
        public void print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
