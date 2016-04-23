using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory.Simple.Tyre
{
    public class SportsTouringTyre : AbstractTyre
    {
        public SportsTouringTyre():base(0,0,0,TyreLocation.Front)
        {
            TyreType=TyreType.SportsTouring;
        }

        public SportsTouringTyre(int w, float a, int d, TyreLocation location) : base(w, a, d, location)
        {
            TyreType = TyreType.SportsTouring;
            if (location == TyreLocation.Rear)
            {
                TyreCompounds = new List<TyreCompound> { TyreCompound.Hard, TyreCompound.MediumHard, TyreCompound.Medium };
                TyreComposition = TyreComposition.TripleCompound;
            }
            else
            {
                TyreCompounds = new List<TyreCompound> { TyreCompound.MediumHard, TyreCompound.Medium };
                TyreComposition = TyreComposition.DuelCompound;
            }
        }
    }
}
