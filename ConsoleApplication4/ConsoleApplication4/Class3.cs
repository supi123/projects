using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Class3
    {
        static void Main(string[] args)
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

            for (i = 0; i < j.Length; i++)
            {
                if (l < 2)
                {
                    string news = j[i];
                    name = name + news;
                    l++;
                    if (l == 3)
                    {
                        lst.Add(name);

                        news = "";


                        name = "";
                    
                    
                    }


                
                }
            
            
            }
        
        }

        

    

    }
}
