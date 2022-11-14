using AbstractFactoryPattern.Entities.AbstractEntity;

namespace AbstractFactoryPattern.Entities.BottleLables
{
    internal class SchweppesLabel : BottleLabel
    {
        public SchweppesLabel()
        {
            Console.WriteLine("SchweppesLabel has been created");
        }
    }
}
