using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{

    class Class2
    {

        public static void Main()
        {
            int a, n;
            Console.WriteLine("Enter a number: ");

            int n = Console.ReadLine();
            scanf("%d", &n);
            for (a = 0; a <= n; a++)
            {
                if (n == a * a)
                {
                    Console.WriteLine("YES");
                    return 0;
                }
            }
            Console.WriteLine("NO");
            return 0;

        }
    }
}