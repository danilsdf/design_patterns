﻿namespace BuilderPattern
{
    public class Laptop
    {
        public string MonitorResolution { get; set; }
        public string Processor { get; set; }
        public string HDD { get; set; }
        public string Memory { get; set; }
        public string Battery { get; set; }
        public override string ToString()
        {
            return $"{MonitorResolution} {Processor} {Memory} {HDD} {Battery}";
        }
    }
}
