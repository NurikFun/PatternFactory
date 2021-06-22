using PatternFactory.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.Implementation
{
    public class CeilingFan : IFan
    {
        public void SwitchOff()
        {
            Console.WriteLine("Ceiling fan turned off!");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Ceiling fan turned on!");
        }
    }
}
