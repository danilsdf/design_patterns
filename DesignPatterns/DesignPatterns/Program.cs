using AbstractFactoryPattern;
using BuilderPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
        {
            //RunAbstractFactory();
            RunBuilder();
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
    }
}