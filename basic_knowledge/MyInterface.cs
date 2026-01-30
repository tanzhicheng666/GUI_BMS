using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_knowledge
{
    interface IMyInterface
    {
        string InterfaceName
        {
            get;        
        }

        int InterfaceNumber
        {
            get;         
        }

        void InterfaceMethod();

    }
}
