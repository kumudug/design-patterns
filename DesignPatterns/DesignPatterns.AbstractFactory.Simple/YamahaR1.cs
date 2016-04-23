using DesignPatterns.AbstractFactory.Simple.Factory;
using DesignPatterns.AbstractFactory.Simple.Tyre;

namespace DesignPatterns.AbstractFactory.Simple
{
    public class YamahaR1:AbstractMotorcycle
    {
        public YamahaR1(IMotorcycleTyreFactory tyreFactory) : base(tyreFactory)
        {
            FrontTyre = tyreFactory.CreateSportsTyre(120, 0.7F, 17, TyreLocation.Front);
            RearTyre = tyreFactory.CreateSportsTyre(200, 0.55F, 17, TyreLocation.Rear);
        }
    }
}
