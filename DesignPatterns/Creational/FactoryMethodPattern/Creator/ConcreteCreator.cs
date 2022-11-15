using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.Creator
{
    internal class ConcreteCreator : Creator
    {
        public override Product.Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
