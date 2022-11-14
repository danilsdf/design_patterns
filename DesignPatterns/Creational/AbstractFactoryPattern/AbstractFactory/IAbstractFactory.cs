using AbstractFactoryPattern.Entities.AbstractEntity;

namespace AbstractFactoryPattern.AbstractFactory
{
    public interface IAbstractFactory
    {
        Bottle CreateBottle();
        Cover CreateCover();
        Water CreateWater();
        BottleLabel CreateLabel();
    }
}
