namespace FactoryMethodPattern.Product
{
    internal sealed class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine(GetHashCode());
        }
    }
}
