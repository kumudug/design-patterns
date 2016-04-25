using CreationalPatterns.FactoryMethod.Implementation.Tyre;

namespace CreationalPatterns.FactoryMethod.Implementation
{
    public class YamahaR1 : AbstractMotorcycle
    {
        public YamahaR1()
        {
            var frontTyre = new DunlopMotorcycleTyre(120, 0.7F, 17);
            var rearTyre = new DunlopMotorcycleTyre(180, 0.55F, 17);
            SetTyres(frontTyre, rearTyre);
        }
    }
}
