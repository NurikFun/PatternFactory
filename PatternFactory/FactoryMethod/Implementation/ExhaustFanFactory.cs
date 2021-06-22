using PatternFactory.Abstraction;
using PatternFactory.Implementation;
using IFanFactory = PatternFactory.FactoryMethod.Abstraction.IFanFactory;


namespace PatternFactory.FactoryMethod.Implementation
{
    public class ExhaustFanFactory : IFanFactory
    {
        public IFan CreateFan()
        {
            return new ExhaustFan();
        }
    }
}
