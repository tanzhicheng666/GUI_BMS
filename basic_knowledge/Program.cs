using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace basic_knowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "33";
            //int a = Convert.ToInt32(str);
            //Console.WriteLine($"the value of a is {a}");
            //Console.WriteLine("Hello world!");
            //Console.WriteLine($"byte: {sizeof(byte)}  byte");
            //Console.WriteLine($"byte: {sizeof(sbyte)}  byte");
            //Console.WriteLine($"short: {sizeof(short)}  byte");
            //Console.WriteLine($"ushort: {sizeof(ushort)}  byte");
            //Console.WriteLine($"int: {sizeof(int)}  byte");
            //Console.WriteLine($"long: {sizeof(long)}  byte");
            //Console.WriteLine($"float: {sizeof(float)}  byte");
            //Console.WriteLine($"double: {sizeof(double)}  byte");
            ////Console.ReadLine();
            //Console.ReadKey();

            Console.WriteLine("Creating object myObj...");
            MyClass myObj = new MyClass("My Object");
            Console.WriteLine("myObj created.");

            for (int i = -1; i <= 0; i++)
            {
                try
                {
                    Console.WriteLine($"\nAttempting to assign {i} to myObj.Val...");
                    myObj.Val = i;
                    Console.WriteLine($"Value {myObj.Val} assigned to myObj.Val.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception {e.GetType().FullName} thrown.");
                    Console.WriteLine($"Message: \n\" {e.Message} \" ");
                    //throw;
                }
            }

            Console.WriteLine("\nOutputing myObj.ToString()....");
            Console.WriteLine(myObj.ToString());

            Console.WriteLine("\nmyDoubledIntPro = 5...");
            //myObj.myDoubledIntProp = 5;
            Console.WriteLine($"Getting myDoubledIntProp of 5 is {myObj.myDoubledIntProp}");

            Console.ReadKey();

            
        }
    }
}
