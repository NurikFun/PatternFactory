using PatternFactory.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.Implementation
{
    public class ExhaustFan : IFan
    {
        public void SwitchOff()
        {
            Console.WriteLine("Exhaust fan turned off!");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Exhaust fan turned off!");
        }
    }
}
