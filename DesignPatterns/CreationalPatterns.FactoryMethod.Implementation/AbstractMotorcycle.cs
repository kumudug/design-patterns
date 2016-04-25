using CreationalPatterns.FactoryMethod.Implementation.Tyre;

namespace CreationalPatterns.FactoryMethod.Implementation
{
    public abstract class AbstractMotorcycle 
    {
        public IMotorcycleTyre MotorcycleTyreFront { get; set; }
        public IMotorcycleTyre MotorcycleTyreRear { get; set; }

        protected void SetTyres<T>(T frontTyre, T rearTyre) where T : IMotorcycleTyre
        {
            MotorcycleTyreFront = frontTyre;
            MotorcycleTyreRear = rearTyre;
        }
    }
}
