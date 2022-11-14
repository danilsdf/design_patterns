using AbstractFactoryPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
        {
            RunAbstractFactory();
        }

        static void RunAbstractFactory()
        {
            var t = new AbstractFactoryMain();

            t.Run();
        }
    }
}