using AbstractFactoryPattern.AbstractFactory;

namespace AbstractFactoryPattern
{
    public class AbstractFactoryMain
    {
        public void Run()
        {
            var client = new Client(new CocaColaFactory());
            client.Run();

            Console.WriteLine(new string('-', 40));

            client = new Client(new PepsiFactory());
            client.Run();

            Console.WriteLine(new string('-', 40));

            client = new Client(new SchweppesFactory());
            client.Run();
        }
    }
}