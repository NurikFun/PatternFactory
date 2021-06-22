using PatternFactory.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.Implementation
{
    public class TableFan : IFan
    {
        public void SwitchOff()
        {
            Console.WriteLine("Table fan turned off!");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Table fan turned on!");
        }
    }
}
