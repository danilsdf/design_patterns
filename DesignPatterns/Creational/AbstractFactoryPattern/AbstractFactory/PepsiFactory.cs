using AbstractFactoryPattern.Entities.AbstractEntity;
using AbstractFactoryPattern.Entities.BottleLables;
using AbstractFactoryPattern.Entities.Bottles;
using AbstractFactoryPattern.Entities.Covers;
using AbstractFactoryPattern.Entities.Waters;

namespace AbstractFactoryPattern.AbstractFactory
{
    internal class PepsiFactory : IAbstractFactory
    {
        public Bottle CreateBottle()
        {
            return new PepsiBottle();
        }

        public Cover CreateCover()
        {
            return new PepsiCover();
        }

        public BottleLabel CreateLabel()
        {
            return new PepsiLabel();
        }

        public Water CreateWater()
        {
            return new PepsiWater();
        }
    }
}
