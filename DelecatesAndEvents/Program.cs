using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace C_workspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 0; i < 2 * n; i++)
            {
                int totalColInRow = i > n ? 2 * n - i : i;
                for (int j = 0; j < totalColInRow; j++)
                {
                    Console.Write((i % 2 == 1) ? "*" : j + 1);
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }


        class SomeClass
        {
            public delegate void Sender(int i);// declration of delegates
            public Sender sender = null;
            public void HugeProcress()
            {
                for (int i = 0; i < 10000; i++)
                {
                    Thread.Sleep(5000);
                    sender(i);//callback
                }
            }
        }
    }
}