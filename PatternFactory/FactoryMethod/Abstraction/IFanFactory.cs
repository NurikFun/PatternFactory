using PatternFactory.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.FactoryMethod.Abstraction
{
    public interface IFanFactory
    {
        IFan CreateFan(); 
    }
}
