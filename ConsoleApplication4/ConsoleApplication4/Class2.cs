using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Class2
    {
        public void  Mains(string[] args)
        {

            string[] j = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("enter your number");
                j[i] = Convert.ToString(Console.ReadLine());
            }
                int l = 1;
                List<string> lst = new List<string>();
                string name = "";

                for (int i = 0; i < j.Length; i++)
                {
                    if (l <= 2)
                    {
                        string news = j[i];
                        name = name + news;
                        if (i == j.Length - 1 && i%2 == 0)
                        {
                            name = name + "_";
                            lst.Add(name);

                        }
                        l++;
                        if (l == 3)
                        {
                            lst.Add(name);

                            news = "";


                            name = "";
                            l = 1;

                        }

                    }
                }

                string joined = String.Join(",", lst.ToArray());

                Console.Write(joined);
                Console.ReadLine();


           }

        



    }















   // class Class2
   // {

   //    public void mainnumber()
   //     {
   //         List<int> numbers = new List<int>() {
   //  5, 3, 9, -2, 5, -2, 4 // please, notice that -2 appeared twice
   //};

   //         // Just do this
   //         numbers.Remove(numbers.Min());

   //         // Let´s print out the test:
   //         // 5, 3, 9, 5, 4
   //         Console.Write(String.Join(", ", numbers));




   //     }
    
    }

