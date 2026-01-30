using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace basic_knowledge
{
    class Program
    {
        static int count = 0;
        static string displayString = "This string will appear one letter at a time. ";
    static void Main(string[] args)
        {
            Connection myConnection = new Connection();
            Display myDisplay = new Display();
            myConnection.MessageArrived += new MessageHandler(myDisplay.DisplayMessage);
            myConnection.Connect();
            Console.ReadKey();
            //Timer myTimer = new Timer(100);
            //myTimer.Elapsed += new ElapsedEventHandler(WriteChar);
            ////myTimer.Elapsed += WriteSentence;
            //myTimer.Start();
            //System.Threading.Thread.Sleep(200);
            //Console.ReadKey();
            //Vector v1 = GetVector("vector1");
            //Vector v2 = GetVector("vector2");
            //Console.WriteLine($"{v1} + {v2} = {v1 + v2}");
            //Console.WriteLine($"{v1} - {v2} = {v1 - v2}");
            //Console.ReadKey();
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

            //Console.WriteLine("Creating object myObj...");
            //MyClass myObj = new MyClass("My Object");
            //Console.WriteLine("myObj created.");

            //ClassWithInterface myInterfaceClass = new ClassWithInterface();
            //IMyInterface myinterface = myInterfaceClass;

            //myinterface.InterfaceMethod();
            ////myinterface.InterfaceName = "Interface name is setted.";
            //Console.WriteLine(myinterface.InterfaceName);
            //Console.WriteLine($"my interface number is {myinterface.InterfaceNumber}.");

            //for (int i = -1; i <= 0; i++)
            //{
            //    try
            //    {
            //        Console.WriteLine($"\nAttempting to assign {i} to myObj.Val...");
            //        myObj.Val = i;
            //        Console.WriteLine($"Value {myObj.Val} assigned to myObj.Val.");
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine($"Exception {e.GetType().FullName} thrown.");
            //        Console.WriteLine($"Message: \n\" {e.Message} \" ");
            //        //throw;
            //    }
            //}

            //Console.WriteLine("\nOutputing myObj.ToString()....");
            //Console.WriteLine(myObj.ToString());

            //Console.WriteLine("\nmyDoubledIntPro = 5...");
            ////myObj.myDoubledIntProp = 5;
            //Console.WriteLine($"Getting myDoubledIntProp of 5 is {myObj.myDoubledIntProp}");

            //Console.ReadKey();
            
        }

        static void WriteChar(object source, ElapsedEventArgs e)
        {
            Console.Write(displayString[count++ % displayString.Length]);
        }

        static void WriteSentence(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("This is other task. ");
        }
        static Vector GetVector(string name)
        {
            Console.WriteLine($"Input {name} magnitude: ");
            double? r = GetNullableDouble();
            Console.WriteLine($"Input {name} angle(in degrees): ");
            double? theta = GetNullableDouble();
            return new Vector(r, theta);
        }

        static double? GetNullableDouble()
        {
            double? result;
            string userInput = Console.ReadLine();

            try
            {
                result = double.Parse(userInput);
            }
            catch (Exception)
            {
                result = null;
                //throw;
            }
            return result;
        }
    }
}
