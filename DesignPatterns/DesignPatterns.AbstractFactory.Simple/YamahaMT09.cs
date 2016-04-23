using DesignPatterns.AbstractFactory.Simple.Factory;
using DesignPatterns.AbstractFactory.Simple.Tyre;

namespace DesignPatterns.AbstractFactory.Simple
{
    // ReSharper disable once InconsistentNaming
    public class YamahaMT09 : AbstractMotorcycle
    {
        public YamahaMT09(IMotorcycleTyreFactory tyreFactory) : base(tyreFactory)
        {
            FrontTyre = tyreFactory.CreateSportsTyre(120, 0.7F, 17, TyreLocation.Front);
            RearTyre = tyreFactory.CreateSportsTyre(180, 0.55F, 17, TyreLocation.Rear);
        }
    }
}
