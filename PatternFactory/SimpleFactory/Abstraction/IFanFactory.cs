using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.Abstraction
{
    public interface IFanFactory
    {
        IFan CreateFan(FanType type);
    }
}
