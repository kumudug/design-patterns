namespace CreationalPatterns.Builder.Implementation.Builder
{
    // ReSharper disable once InconsistentNaming
    public class MotorcycleXSR900Builder : MotorcycleBuilder
    {
        public MotorcycleXSR900Builder()
        {
            Motorcycle = new Motorcycle { Name = "XSR 900" };
        }

        public override void BuildChasis()
        {
            Motorcycle.Chasis = "Tibular lean";
        }

        public override void BuildEngine()
        {
            Motorcycle.Engine = "850cc 96nm";
        }

        public override void BuildFuelTank()
        {
            Motorcycle.FuelTank = "14L Metal retro";
        }

        public override void BuildSuspension()
        {
            Motorcycle.Suspension = "Upside down forks front. Monoshock rear";
        }

        public override void BuildHeadAssembly()
        {
            Motorcycle.HeadAssembly = "Single hallogen lamps with analog retro custer";
        }

        public override void BuildTailAssembly()
        {
            Motorcycle.TailAssembly = "LED tail lights";
        }
    }
}