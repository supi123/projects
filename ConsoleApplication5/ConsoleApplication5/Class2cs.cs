using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication5
{
    class Class2cs
    {
        
        

            public static void Main()
            {

  //              int n = 1;
  //              Double sp = 7/2;
  //              int counter = 1;
  //              int l  = 0;

  //              l = Convert.ToInt32(Math.Floor(sp));



  //              for (int i = 0; i <7; i++)


  //              {
  //                  for (int j = 0; j < l; j++)
  //                  {
  //                      Console.Write(" ");
                    
  //                  }
  //                  for (int f = 0; f < n; f++)
  //                  {
  //                      Console.Write("*");
  //                  }

                    
  //                  if (n < 7 && counter == 1)
  //                  {
  //                      l--;
  //                      n = n + 2;
  //                  }
  //                  else if (n == 7 || counter >= 1)
  //                  {
  //                      l++;

  //                      n = n - 2;

  //                    counter =  counter + 1;
  //                  }

  //                  Console.WriteLine(" ");




  //}


  //                      Console.ReadLine();


                Console.WriteLine("Enter the value for a");

                string a = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter the value for b");

                string b = Convert.ToString(Console.ReadLine());

                string c = a + b;

                var charArray = c.ToCharArray();

                //Array[] charArray = new Array;
                for (int i = 0; i < c.Length; i++)
                {

                    Console.WriteLine(charArray[i]);

                   // Console.ReadLine();
                }





                   //{'1','2','3','4','5'}
                   // charArray[] = b.ToCharArray();


                   Console.ReadLine();

                //Console.WriteLine("Enter the string");


                //                string n = Convert.ToString(Console.ReadLine());
                //                string l = null;

                //                for(int i = 0; i< n.Length; i++)

              //  {

                //    l = l + n;


               //// }
               // Console.WriteLine(l);


               // Console.ReadLine();

                //string[] arr = new string[4];

                //for (int i = 0; i < 4; i++)
                //{
                //    Console.WriteLine("Enter the string");

                //    arr[i] = Console.ReadLine();


                //}

                //string[] newarr = new string[4];
                //for (int j = 0; j < arr.Length; j++)
                //{
                //    for (int K = j + 1; K < arr.Length; K++)
                //    {
                //        if (Convert.ToInt32(arr[j]) > Convert.ToInt32(arr[K]))
                //        {

                //            string temp;

                //            temp = arr[j];
                //            arr[j] = arr[K];

                //            arr[K] = temp;


                //        }




                //    }
                //    newarr[j] = arr[j];

                //}

                //for (int f = 0; f < newarr.Length; f++)
                //{
                //    Console.WriteLine(newarr[f]);
                //}
                //Console.ReadLine();

               // childclass c = new childclass();
//                string hex = "7A"; // the incoming 16 digit endian string.

//string[] hexa = new string[4]; // break hex into array of 4 digits each.

//int decAgain =0; // final output number.

//int j = 0; // for incrementing hexa's array element.

//for (int i = 0; i < hex.Length; i+=4) // loop through hex, 4 digits at a time.
//{

//    hexa[j] = hex.Substring(i,2); 

//    decAgain  += int.Parse(hexa[j], System.Globalization.NumberStyles.HexNumber) ; // convert each hexa element to int and multiply * 256
//    j++;

}
                
                // //scanf("%d", &n);
               // for (a = 0; a <= n; a++)
               // {
               //     if (n == a * a)
               //     {
               //         Console.WriteLine("YES");
               //         //return 0;
               //         break;


               //     }

               //     else if (n < a * a)

               //     {
               //         Console.WriteLine("NO");
               //         break;
                    
               //     }
               // }


               //Console.ReadLine();
                    



               //// return 0;


               

            }
        }

    public class baseClasss
    {
       public int? a = 10;
        public int? b = 20;
    }

    public class childclass : baseClasss
    {

        
        public void add()
        {
            int? c = 0;
            c = a + b;
            Console.WriteLine(c);
        }
    }

    

