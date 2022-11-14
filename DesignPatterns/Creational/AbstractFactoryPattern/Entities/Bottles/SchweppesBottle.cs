using AbstractFactoryPattern.Entities.AbstractEntity;

namespace AbstractFactoryPattern.Entities.Bottles
{
    internal class SchweppesBottle : Bottle
    {
        public SchweppesBottle()
        {
            Console.WriteLine("SchweppesBottle has been created");
        }
        public override void Cover(Cover cover)
        {
            Console.WriteLine($"{this} interacts with {cover}");
        }

        public override void FullWithWater(Water water)
        {
            Console.WriteLine($"{this} interacts with {water}");
        }

        public override void StickLabel(BottleLabel label)
        {
            Console.WriteLine($"{this} interacts with {label}");
        }
    }
}
