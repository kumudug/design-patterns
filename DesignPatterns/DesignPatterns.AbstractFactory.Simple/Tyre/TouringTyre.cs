using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory.Simple.Tyre
{
    public class TouringTyre : AbstractTyre
    {
        public TouringTyre() : base(0, 0, 0, TyreLocation.Front)
        {
            TyreType = TyreType.Touring;
        }

        public TouringTyre(int w, float a, int d, TyreLocation location) : base(w, a, d, location)
        {
            TyreType = TyreType.Touring;
            if (location == TyreLocation.Rear)
            {
                TyreCompounds = new List<TyreCompound> {TyreCompound.Hard, TyreCompound.MediumHard};
                TyreComposition = TyreComposition.DuelCompound;
            }
            else
            {
                TyreCompounds = new List<TyreCompound> {TyreCompound.MediumHard, TyreCompound.Medium};
                TyreComposition = TyreComposition.DuelCompound;
            }
        }
    }
}