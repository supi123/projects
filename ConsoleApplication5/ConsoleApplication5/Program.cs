using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{

    public class mcCalculator
    {
        //public int p1;
        //public int p2;
        //public string p3;
        //public string date;
        //public mcCalculator(int p1, int p2, string p3,string date )
        //{
        //    // TODO: Complete member initialization
        //    this.p1 = p1;
        //    this.p2 = p2;
        //    this.p3 = p3;
        //    this.date = date;
        //}
        public int doctor_id { get; set; }
        public int department_id { get; set; }
        public string time { get; set; }

        public string date_doctor { get; set; }


    }





    public class news
    {
        //private int p6;
        //private int p7;
        //private string p8;
        //public string dates;
        //public news(int p6, int p7, string p8,string dates)
        //{
        //    // TODO: Complete member initialization
        //    this.p6 = p6;
        //    this.p7 = p7;
        //    this.p8 = p8;
        //    this.dates = dates;
        //}
        public int doctor_ids { get; set; }
        public int department_ids { get; set; }
        public string times { get; set; }
        public string date_doctors { get; set; }
    }









    class mcStart
    {
//        public  void Mains()
//{

//    List<mcCalculator> sj = new List<mcCalculator>();
//    sj.Add(new mcCalculator() { doctor_id = 1, department_id = 2, time = "12:20", date_doctor = "12-11-2017" });
//    sj.Add(new mcCalculator() { doctor_id = 1, department_id = 2, time = "12:30", date_doctor = "12-11-2017" });

//    sj.Add(new mcCalculator() { doctor_id = 1, department_id = 2, time = "12:40", date_doctor = "12-11-2017" });

//    sj.Add(new mcCalculator() { doctor_id = 1, department_id = 2, time = "01:10", date_doctor = "12-11-2017" });
//    sj.Add(new mcCalculator() { doctor_id = 1, department_id = 2, time = "01:20", date_doctor = "12-11-2017" });

//    sj.Add(new mcCalculator() { doctor_id = 1, department_id = 2, time = "01:30", date_doctor = "12-11-2017" });

//    sj.Add(new mcCalculator() { doctor_id = 1, department_id = 2, time = "01:40", date_doctor = "12-11-2017" });


    
//    List<news> nw = new List<news>();
//    nw.Add(new news() { doctor_ids = 1, department_ids = 2, times = "12:20", date_doctors = "12-11-2017" });
//    nw.Add(new news() { doctor_ids = 1, department_ids = 2, times = "12:30", date_doctors = "12-11-2017" });



//    var list = nw.Where(item => item.date_doctors == "12-11-2017" && item.department_ids == 2 && item.doctor_ids == 1).Select(o => o.times).ToList();

//    foreach (var m in list)
//    {

//        var newlist = sj.Where(item => item.date_doctor == "12-11-2017" && item.department_id == 2 && item.doctor_id == 1 && item.time == m).SingleOrDefault();

//        sj.Remove(newlist);
    
//    }

//    sj.ToList() ;
//             foreach (mcCalculator item in sj)
//            Console.WriteLine(item.date_doctor);
//        Console.ReadLine();
//    }
    
    }














   // class Program
   // {

   //     static void Main()
   //     {
   ////         List<int> numbers = new List<int>() {
   ////  5, 3, 9, -2, 5, -2, 4 // please, notice that -2 appeared twice
   ////};

   ////         // Just do this
   ////        // numbers.Remove(numbers.Min());
   ////         //numbers.Remove(numbers.Min());
   ////         int min = numbers.Min();
   ////         List<int> list = numbers.Where(val => val != min).ToList();

           
   ////         // Let´s print out the test:
   ////         // 5, 3, 9, 5, 4
   ////         Console.Write(String.Join(", ", list));
   ////         Console.ReadLine();

   //       //  Console.WriteLine("This is a test to help Rad");
   //         Console.WriteLine("Please enter a string");
   //         string CurrentString = Console.ReadLine();
   //         int j = 0; int k = 0;
   //         for (int i = 0; i < CurrentString.Length; i++)
   //         {
   //             Console.WriteLine(CurrentString[i] + "\t" + "Unicode code is: " + (int)CurrentString[i]);

   //             j = (int) CurrentString[0];

   //             k = (int)CurrentString[i];


   //         }
   //         int l = 0;

   //         for (int i = j; i < k; i++)
   //         {

   //             if ((int)CurrentString[l] != i)
   //             {

   //                 char charData = (char)i;

   //                 Console.WriteLine("missing character is" + charData);

   //                 Console.ReadLine();

   //             }
   //             else
   //             {

   //                 l++;

   //             }
   //         }

   //        // char charData = (char)98;

   //         // This will display c


   //     }

   // }
}
