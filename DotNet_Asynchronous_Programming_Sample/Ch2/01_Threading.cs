using System;
using System.Threading;
using NUnit.Framework;

namespace DotNet_Asynchronous_Programming_Sample.Ch2
{
    [TestFixture]
    public class Threading
    {
        [Test]
        public static void ThreadMain()
        {
            var t1 = new Thread(MyTask); //Create a thread
            t1.Start(); //Start the thread 

            
            for (var i = 0; i < 500; i++) //use for loop to print `.`
                Console.Write(".");
        }

        private static void MyTask()
        {
            for (var i = 0; i < 500; i++) // use for loop to print `[thread id]`
                Console.Write("[" + Thread.CurrentThread.ManagedThreadId + "]");
        }
    }
}