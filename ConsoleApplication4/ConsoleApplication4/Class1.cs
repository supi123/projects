using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Class1
    {

        public void prime_no()
        {
            int num, i, count = 0;
            num = 3;
            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0 && num != 1)
                Console.WriteLine("%d is a prime number", num);
            else
                Console.WriteLine("%d is not a prime number", num);
            //return 0;

        }
    }
}
