using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace KuberFundTransfer.Kuber
{
    public class MulT1
    {
        public void process()
        {
            Console.WriteLine("please wait process is working----");
            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine("\t-");
                Thread.Sleep(500);

            }
            Console.WriteLine();
        }
    }
}
