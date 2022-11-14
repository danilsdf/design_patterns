using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.Entities.AbstractEntity;

namespace AbstractFactoryPattern
{
    internal class Client
    {
        private readonly Water _water;
        private readonly Bottle _bottle;
        private readonly BottleLabel _label;
        private readonly Cover _cover;

        public Client(IAbstractFactory factory)
        {

            _bottle = factory.CreateBottle();
            _water = factory.CreateWater();
            _cover = factory.CreateCover();
            _label = factory.CreateLabel();
        }
        public void Run()
        {
            _bottle.FullWithWater(_water);
            _bottle.Cover(_cover);
            _bottle.StickLabel(_label);
        }
    }
}
