using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_knowledge
{
    class MyClass
    {
        public readonly string Name;
        private int intVal;
        public int Val
        {
            get { return this.intVal; }
            set {
                if (value <= 10 && value >= 0)
                    intVal = value;
                else
                    throw (new ArgumentOutOfRangeException("Val", value, "Val must be assigned a value between 0 and 10."));
            }
        }

        

        public override string ToString() => "Name: " + Name + "\nValue: " + Val;

        private MyClass() : this("Default Name") { }
        public MyClass(string newName)
        {
            Name = newName;
            intVal = 0;
        }

        private int myDoubledInt = 5;

        public int myDoubledIntProp => (myDoubledInt * 2);
        

    }

    #region use interface in the Class

    class ClassWithInterface : IMyInterface
    {
        public string InterfaceName => "Class with interface";

        public int InterfaceNumber => 1;

        public void InterfaceMethod()
        {
            Console.WriteLine("this is method of class using interface!");
        }


    }

    #endregion
}
