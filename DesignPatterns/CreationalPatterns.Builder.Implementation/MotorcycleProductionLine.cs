using CreationalPatterns.Builder.Implementation.Builder;

namespace CreationalPatterns.Builder.Implementation
{
    public class MotorcycleProductionLine
    {
        public void BuildMotorcycle(MotorcycleBuilder builder)
        {
            builder.BuildChasis();
            builder.BuildEngine();
            builder.BuildFuelTank();
            builder.BuildSuspension();
            builder.BuildHeadAssembly();
            builder.BuildTailAssembly();
            builder.Motorcycle.PrintDetails();
            builder.Motorcycle.PrintDetails();
        }
    }
}