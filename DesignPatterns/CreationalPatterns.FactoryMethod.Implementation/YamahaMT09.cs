using CreationalPatterns.FactoryMethod.Implementation.Tyre;

namespace CreationalPatterns.FactoryMethod.Implementation
{
    public class YamahaMT09 : AbstractMotorcycle
    {
        public YamahaMT09()
        {
            var frontTyre = new BridgestoneMotorcycleTyre(120, 0.7F, 17);
            var rearTyre = new BridgestoneMotorcycleTyre(180, 0.55F, 17);
            SetTyres(frontTyre, rearTyre);
        }
    }
}
