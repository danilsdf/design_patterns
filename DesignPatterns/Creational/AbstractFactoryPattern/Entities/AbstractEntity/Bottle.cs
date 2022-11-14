namespace AbstractFactoryPattern.Entities.AbstractEntity
{
    public abstract class Bottle
    {
        public abstract void FullWithWater(Water water);
        public abstract void StickLabel(BottleLabel label);
        public abstract void Cover(Cover cover);
    }
}
