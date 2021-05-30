using System;
using System.Threading;
using NUnit.Framework;

namespace DotNet_Asynchronous_Programming_Sample.Ch2
{
    [TestFixture]
    public class ThreadingStartWithParameter
    {
        [Test]
        public static void ThreadMain()
        {
            var t1 = new Thread(MyTask);
            var t2 = new Thread(MyTask);
            var t3 = new Thread(MyTask);

            t1.Start("X");
            t2.Start("Y");
            t3.Start("Z");

            for (var i = 0; i < 500; i++) Console.Write(".");
        }

        private static void MyTask(object param)
        {
            for (var i = 0; i < 500; i++) 
                Console.Write(param);
        }
    }
}