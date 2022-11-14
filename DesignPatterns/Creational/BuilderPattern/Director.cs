using BuilderPattern.Builders;

namespace BuilderPattern
{
    internal class Director
    {
        private readonly LaptopBuilder _laptopBuilder;

        public Director(LaptopBuilder laptopBuilder)
        {
            _laptopBuilder = laptopBuilder;
        }

        public Laptop GetLaptop()
        {
            return _laptopBuilder.GetMyLaptop();
        }

        public void ConstructLaptop()
        {
            _laptopBuilder.CreateNewLaptop();
            _laptopBuilder.SetMonitorResolution();
            _laptopBuilder.SetProcessor();
            _laptopBuilder.SetMemory();
            _laptopBuilder.SetHDD();
            _laptopBuilder.SetBattery();
        }
    }
}
