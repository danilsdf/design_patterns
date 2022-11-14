using AbstractFactoryPattern.Entities.AbstractEntity;

namespace AbstractFactoryPattern.Entities.Waters
{
    internal class SchweppesWater : Water
    {
        public SchweppesWater()
        {
            Console.WriteLine("SchweppesWater has been created");
        }
    }
}
