using AbstractFactoryPattern.Entities.AbstractEntity;
using AbstractFactoryPattern.Entities.BottleLables;
using AbstractFactoryPattern.Entities.Bottles;
using AbstractFactoryPattern.Entities.Covers;
using AbstractFactoryPattern.Entities.Waters;

namespace AbstractFactoryPattern.AbstractFactory
{
    internal class SchweppesFactory : IAbstractFactory
    {
        public Bottle CreateBottle()
        {
            return new SchweppesBottle();
        }

        public Cover CreateCover()
        {
            return new SchweppesCover();
        }

        public BottleLabel CreateLabel()
        {
            return new SchweppesLabel();
        }

        public Water CreateWater()
        {
            return new SchweppesWater();
        }
    }
}
