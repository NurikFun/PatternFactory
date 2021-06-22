using PatternFactory.Abstraction;
using PatternFactory.Implementation;
using IFanFactory = PatternFactory.FactoryMethod.Abstraction.IFanFactory;


namespace PatternFactory.FactoryMethod.Implementation
{
    public class TableFanFactory : IFanFactory
    {
        public IFan CreateFan()
        {
            return new TableFan();
        }
    }
}
