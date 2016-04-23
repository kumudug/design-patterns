using DesignPatterns.AbstractFactory.Simple.Factory;
using DesignPatterns.AbstractFactory.Simple.Tyre;

namespace DesignPatterns.AbstractFactory.Simple
{
    public class YamahaR1M : AbstractMotorcycle
    {
        public YamahaR1M(IMotorcycleTyreFactory tyreFactory) : base(tyreFactory)
        {
            FrontTyre = tyreFactory.CreateTrackTyre(120, 0.7F, 17, TyreLocation.Front);
            RearTyre = tyreFactory.CreateTrackTyre(200, 0.55F, 17, TyreLocation.Rear);
        }
    }
}