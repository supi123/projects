using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
           // int i;
           // int j;
           // int k;
           // Console.WriteLine("Enter First no");
           // i = int.Parse(Console.ReadLine());
           // Console.WriteLine("Enter  Second no");
           // j = int.Parse(Console.ReadLine());

           // k = i;
           // i = j;
           // j = k;


           // Console.WriteLine(i);

           // Console.WriteLine(j);

           //Console.ReadLine();


            //for(int i=1;i<=5;i++)
            //{
            //    for (int j = 0; j <i; j++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine("");
            //}
            //Console.ReadKey();


            //for (int i = 5; i <=0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}

            //xml d = new xml();
            //d.d();

            GenerateXml n = new GenerateXml();
            n.Mains();
            
          

            Console.ReadKey();
        }
    }
}
