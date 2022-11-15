using FactoryMethodPattern.Creator;

namespace FactoryMethodPattern
{
    public class FactoryMethodMain
    {
        public void Run()
        {
            var creator = new ConcreteCreator();
            var product = creator.FactoryMethod();

            creator.AnOperation();
        }
    }
}
