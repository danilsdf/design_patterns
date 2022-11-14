using AbstractFactoryPattern.Entities.AbstractEntity;
using AbstractFactoryPattern.Entities.BottleLables;
using AbstractFactoryPattern.Entities.Bottles;
using AbstractFactoryPattern.Entities.Covers;
using AbstractFactoryPattern.Entities.Waters;

namespace AbstractFactoryPattern.AbstractFactory
{
    internal class CocaColaFactory : IAbstractFactory
    {
        public Bottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public Cover CreateCover()
        {
            return new CocaColaCover();
        }

        public BottleLabel CreateLabel()
        {
            return new CocaColaLabel();
        }

        public Water CreateWater()
        {
            return new CocaColaWater();
        }
    }
}
