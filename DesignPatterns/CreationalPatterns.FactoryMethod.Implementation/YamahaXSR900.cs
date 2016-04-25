using CreationalPatterns.FactoryMethod.Implementation.Tyre;

namespace CreationalPatterns.FactoryMethod.Implementation
{
    // ReSharper disable once InconsistentNaming
    public class YamahaXSR900 : AbstractMotorcycle
    {
        public YamahaXSR900()
        {
            var frontTyre = new PirelliMotorcycleTyre(120, 0.7F, 17);
            var rearTyre = new PirelliMotorcycleTyre(180, 0.55F, 17);
            SetTyres(frontTyre, rearTyre);
        }
    }
}