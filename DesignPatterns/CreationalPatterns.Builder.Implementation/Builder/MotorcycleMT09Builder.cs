namespace CreationalPatterns.Builder.Implementation.Builder
{
    // ReSharper disable once InconsistentNaming
    public class MotorcycleMT09Builder:MotorcycleBuilder
    {
        public MotorcycleMT09Builder()
        {
            Motorcycle = new Motorcycle {Name = "MT09"};
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
            Motorcycle.FuelTank = "14L";
        }

        public override void BuildSuspension()
        {
            Motorcycle.Suspension = "Upside down forks front. Monoshock rear";
        }

        public override void BuildHeadAssembly()
        {
            Motorcycle.HeadAssembly = "Single hallogen lamps with right alighed cluster";
        }

        public override void BuildTailAssembly()
        {
            Motorcycle.TailAssembly = "LED tail lights";
        }
    }
}