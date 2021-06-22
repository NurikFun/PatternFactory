using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.Abstraction
{
    public enum FanType
    {
        TableFan,
        CeilingFan,
        ExhaustFan
    }
    public interface IFan
    {
        void SwitchOn();
        void SwitchOff();
    }
}
