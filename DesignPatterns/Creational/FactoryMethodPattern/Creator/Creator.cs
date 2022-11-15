namespace FactoryMethodPattern.Creator
{
    internal abstract class Creator
    {
        private Product.Product _product;

        public abstract Product.Product FactoryMethod();

        public void AnOperation()
        {
            _product = FactoryMethod();
        }
    }
}
