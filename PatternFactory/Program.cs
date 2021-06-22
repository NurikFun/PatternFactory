using PatternFactory.Abstraction;
using PatternFactory.FactoryMethod.Implementation;
using PatternFactory.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Simple Factory 
            IFanFactory simpleFactory = new FanFactory();
            IFan fan = simpleFactory.CreateFan(FanType.TableFan);
            fan.SwitchOn();
            */

            FactoryMethod.Abstraction.IFanFactory fanFactory = new CeilingFanFactory();
            IFan fan = fanFactory.CreateFan();
            fan.SwitchOn();

            Console.ReadKey();
        }
    }
}
