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
            Console.WriteLine("Hello world!");
            Console.WriteLine($"byte: {sizeof(byte)}  byte");
            Console.WriteLine($"byte: {sizeof(sbyte)}  byte");
            Console.WriteLine($"short: {sizeof(short)}  byte");
            Console.WriteLine($"ushort: {sizeof(ushort)}  byte");
            Console.WriteLine($"int: {sizeof(int)}  byte");
            Console.WriteLine($"long: {sizeof(long)}  byte");
            Console.WriteLine($"float: {sizeof(float)}  byte");
            Console.WriteLine($"double: {sizeof(double)}  byte");
            //Console.ReadLine();
            Console.ReadKey();
            
        }
    }
}
