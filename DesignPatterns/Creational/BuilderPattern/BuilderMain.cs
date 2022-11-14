using BuilderPattern.Builders;

namespace BuilderPattern
{
    public class BuilderMain
    {
        public void Run()
        {
            var gaming = new GamingLaptop();
            var cheap = new CheapLaptop();
            var office = new OfficeLaptop();

            var director = new Director(gaming);

            director.ConstructLaptop();

            var laptop = director.GetLaptop();

            Console.WriteLine(laptop.ToString());
        }
    }
}
