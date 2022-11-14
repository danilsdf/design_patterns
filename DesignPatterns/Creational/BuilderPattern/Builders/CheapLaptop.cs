namespace BuilderPattern.Builders
{
    internal class CheapLaptop : LaptopBuilder
    {
        public override void SetBattery()
        {
            Laptop.Battery = "2 lbs";
        }

        public override void SetHDD()
        {
            Laptop.HDD = "250 Gb";
        }

        public override void SetMemory()
        {
            Laptop.Memory = "1024 Mb";
        }

        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1100X800";
        }

        public override void SetProcessor()
        {
            Laptop.Processor = "Core 2 Duo, 2.5 GHz";
        }
    }
}
