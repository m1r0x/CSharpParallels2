using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpParallels2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(new Action(Task1));
            Task t2 = new Task(new Action(Task2));
            Task t3 = new Task(new Action(Task3));

            t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine("Done!");
            Console.ReadKey();


            Parallel.Invoke(Task1, Task2, Task3);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        static void Task1()
        {
            for (int i=0; i < 10; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine(" #1 ");
            }
        }
        static void Task2()
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine(" #2 ");
            }
        }
        static void Task3()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine(" #3 ");
            }
        }
    }
}
