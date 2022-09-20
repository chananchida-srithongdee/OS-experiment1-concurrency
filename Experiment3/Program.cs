using System;
using System.Threading;
// experiment3 : pause a thread
namespace Lab_OS_Concurrency02
{
    class Program
    {
        static int resource = 10000;
        static void TestThread1()
        {
            resource = 55555;
            // Console.WriteLine("Done");

        }
        static void Main(string[] args)
        {
            Thread th1 = new Thread(TestThread1);
            th1.Start();
            Thread.Sleep(100);
            Console.WriteLine("resource={0}", resource);
        }
    }
}