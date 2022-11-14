using AbstractFactoryPattern.Entities.AbstractEntity;

namespace AbstractFactoryPattern.Entities.BottleLables
{
    public class PepsiLabel : BottleLabel
    {
        public PepsiLabel()
        {
            Console.WriteLine("PepsiLabel has been created");
        }
    }
}
