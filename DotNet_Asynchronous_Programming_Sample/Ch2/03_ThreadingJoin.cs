using System;
using System.Threading;
using NUnit.Framework;

namespace DotNet_Asynchronous_Programming_Sample.Ch2
{
    [TestFixture]
    public class ThreadingJoin
    {
        [Test]
        public static void ThreadMain()
        {
            var t1 = new Thread(MyTask);
            var t2 = new Thread(MyTask);
            var t3 = new Thread(MyTask);

            t1.Start("T1");
            t2.Start("T2");
            t3.Start("T3");

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("Task all completed.");
        }

        private static void MyTask(object param)
        {
            Console.WriteLine("{0} 已開始執行 MyTask()", param);
            Thread.Sleep(3000); // 令目前這條執行緒暫停三秒。
            Console.WriteLine("{0} 即將完成工作", param);
        }
    }
}