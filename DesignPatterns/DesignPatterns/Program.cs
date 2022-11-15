using AbstractFactoryPattern;
using BuilderPattern;
using FactoryMethodPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
        {
            RunAbstractFactory();
            RunBuilder();
            RunFactoryMethod();
        }

        static void RunAbstractFactory()
        {
            var abstractFactory = new AbstractFactoryMain();

            abstractFactory.Run();
        }

        static void RunBuilder()
        {
            var builder = new BuilderMain();

            builder.Run();
        }

        static void RunFactoryMethod()
        {
            var factoryMethod = new FactoryMethodMain();

            factoryMethod.Run();
        }
    }
}