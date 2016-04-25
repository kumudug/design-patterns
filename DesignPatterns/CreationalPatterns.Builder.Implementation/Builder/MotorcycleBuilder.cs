namespace CreationalPatterns.Builder.Implementation.Builder
{
    public abstract class MotorcycleBuilder
    {
        public Motorcycle Motorcycle { get; set; }

        public abstract void BuildChasis();
        public abstract void BuildEngine();
        public abstract void BuildFuelTank();
        public abstract void BuildSuspension();
        public abstract void BuildHeadAssembly();
        public abstract void BuildTailAssembly();
    }
}