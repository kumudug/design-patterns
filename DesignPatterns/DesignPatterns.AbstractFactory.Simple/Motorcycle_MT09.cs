using DesignPatterns.AbstractFactory.Simple.Tyre;

namespace DesignPatterns.AbstractFactory.Simple
{
    public class Motorcycle_MT09 : AbstractMotorcycle
    {
        public Motorcycle_MT09(IMotorcycleTyreFactory tyreFactory) : base(tyreFactory)
        {
            FrontTyre = tyreFactory.CreateSportsTyre(120, 0.7F, 17, TyreLocation.Front);
            RearTyre = tyreFactory.CreateSportsTyre(180, 0.55F, 17, TyreLocation.Rear);
        }
    }
}
