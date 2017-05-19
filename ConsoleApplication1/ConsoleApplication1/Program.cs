using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Threading;


namespace ReflectionTest
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Type testType = typeof(TestClass);
//            ConstructorInfo ctor = testType.GetConstructor(System.Type.EmptyTypes);
//            if (ctor != null)
//            {
//                object instance = ctor.Invoke(null);
//                MethodInfo methodInfo = testType.GetMethod("TestMethod");
//                Console.WriteLine(methodInfo.Invoke(instance, new object[] { 10 }));
//            }
//            Console.ReadKey();
//        }
//    }

//    public class TestClass
//    {
//        private int numberToAdd;
//        private int numberToAdds ;
//        private int numberToAddss;

//        public int TestMethod(int numberToAdd)
//        {
//            return numberToAdd;
//        }
//    }
////}
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            var t = typeof(MyClass);

//            foreach (var m in t.GetMethods())
//            {
//                Console.WriteLine(m.Name);
//            }
//            Console.ReadLine();
//        }
//    }


//    public class MyClass
//    {
//        public int Add(int x, int y)
//        {
//            return x + y;
//        }

//        public int Subtract(int x, int y)
//        {
//            return x - y;
//        }
//    }
//}
{

    delegate void doWork(string input);


    class myMethodCollection
    {

        public static EventWaitHandle oWait = new EventWaitHandle(false, EventResetMode.AutoReset, "US");
        private List<doWork> _storedMethodCalls;

        public myMethodCollection()
        {

            _storedMethodCalls = new List<doWork>();
        }

        public List<doWork> MethodCalls
        {

            get
            {

                return this._storedMethodCalls;
            }

        }

        public void IMTarget1(string input)
        {

            Console.WriteLine("Target 1 is called" + "..." + input);
        }

        public void IMTarget2(string input)
        {

            Console.WriteLine("Target 2 is called" + "..." + input);
        }

        public void IMTarget3(string input)
        {

            Console.WriteLine("Target 3 is called" + "..." + input);
        }

        public void IMTarget4(string input)
        {

            Console.WriteLine("Target 4 is called" + "..." + input);
        }

        public void IMTarget5(string input)
        {

            Console.WriteLine("Target 5 is called" + "..." + input);
        }

        public void InvokeMethods()
        {

            int i = 0; foreach (doWork dw in this._storedMethodCalls)
            {

                dw("Performing task " + i++);
            }

        }

    }



    class Program
    {

        static void Main(string[] args)
        {

            myMethodCollection oMethodCollection = new myMethodCollection(); doWork oDoWork1 = new doWork(oMethodCollection.IMTarget1);
            oMethodCollection.MethodCalls.Add(oDoWork1);

            doWork oDoWork2 = new doWork(oMethodCollection.IMTarget2);
            oMethodCollection.MethodCalls.Add(oDoWork2);

            doWork oDoWork3 = new doWork(oMethodCollection.IMTarget3);
            oMethodCollection.MethodCalls.Add(oDoWork3);

            doWork oDoWork4 = new doWork(oMethodCollection.IMTarget4);
            oMethodCollection.MethodCalls.Add(oDoWork4);

            doWork oDoWork5 = new doWork(oMethodCollection.IMTarget5);
            oMethodCollection.MethodCalls.Add(oDoWork5);

            Console.WriteLine("waiting for notification from ClientSignal.exe");

           // myMethodCollection.oWait.WaitOne();
            Console.WriteLine("notified by ClientSignal.exe. Now I will call target methods");
            oMethodCollection.InvokeMethods();

            Console.ReadLine();
        }

    }

}

