using DesignPatterns.AbstractFactory.Simple.Factory;
using DesignPatterns.AbstractFactory.Simple.Tyre;

namespace DesignPatterns.AbstractFactory.Simple
{
    public class YamahaXSR900:AbstractMotorcycle
    {
        public YamahaXSR900(IMotorcycleTyreFactory tyreFactory) : base(tyreFactory)
        {
            FrontTyre = tyreFactory.CreateSportsTouringTyre(120, 0.7F, 17, TyreLocation.Front);
            RearTyre = tyreFactory.CreateSportsTouringTyre(180, 0.55F, 17, TyreLocation.Rear);
        }
    }
}
