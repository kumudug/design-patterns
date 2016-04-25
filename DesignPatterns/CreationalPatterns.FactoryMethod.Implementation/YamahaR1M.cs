using CreationalPatterns.FactoryMethod.Implementation.Tyre;

namespace CreationalPatterns.FactoryMethod.Implementation
{
    public class YamahaR1M : AbstractMotorcycle
    {
        public YamahaR1M()
        {
            var frontTyre = new MichelinMotorcycleTyre(120, 0.7F, 17);
            var rearTyre = new MichelinMotorcycleTyre(200, 0.55F, 17);
            SetTyres(frontTyre, rearTyre);
        }
    }
}
