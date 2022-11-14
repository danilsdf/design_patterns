namespace BuilderPattern.Builders
{
    internal class OfficeLaptop : LaptopBuilder
    {
        public override void SetBattery()
        {
            Laptop.Battery = "6 lbs";
        }

        public override void SetHDD()
        {
            Laptop.HDD = "400 Gb";
        }

        public override void SetMemory()
        {
            Laptop.Memory = "6144 Mb";
        }

        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1400X1200";
        }

        public override void SetProcessor()
        {
            Laptop.Processor = "Core 4 Duo, 3.2 GHz";
        }
    }
}
