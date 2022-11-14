using AbstractFactoryPattern.Entities.AbstractEntity;

namespace AbstractFactoryPattern.Entities.Waters
{
    public class PepsiWater : Water
    {
        public PepsiWater()
        {
            Console.WriteLine("PepsiWater has been created");
        }
    }
}
