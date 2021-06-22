using PatternFactory.Abstraction;
using PatternFactory.Implementation;
using IFanFactory = PatternFactory.FactoryMethod.Abstraction.IFanFactory;

namespace PatternFactory.FactoryMethod.Implementation
{
    public class CeilingFanFactory : IFanFactory
    {
        public IFan CreateFan()
        {
            return new CeilingFan();
        }
    }
}
