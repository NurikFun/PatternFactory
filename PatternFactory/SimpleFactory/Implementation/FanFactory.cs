using PatternFactory.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.Implementation
{
    public class FanFactory : IFanFactory
    {
        public IFan CreateFan(FanType type)
        {
            switch (type)
            {
                case FanType.CeilingFan:
                    return new CeilingFan();
                case FanType.ExhaustFan:
                    return new ExhaustFan();
                default:
                    return new TableFan();
            }
        }
    }
}
