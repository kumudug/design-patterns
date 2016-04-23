using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory.Simple.Tyre
{
    public class DirtTyre : AbstractTyre
    {
        public DirtTyre() : base(0, 0, 0, TyreLocation.Front)
        {
            TyreType = TyreType.Dirt;
        }

        public DirtTyre(int w, float a, int d, TyreLocation location) : base(w, a, d, location)
        {
            TyreType = TyreType.Dirt;
            if (location == TyreLocation.Rear)
            {
                TyreCompounds = new List<TyreCompound> {TyreCompound.Hard, TyreCompound.MediumHard};
                TyreComposition = TyreComposition.DuelCompound;
            }
            else
            {
                TyreCompounds = new List<TyreCompound> {TyreCompound.MediumHard};
                TyreComposition = TyreComposition.SingleCompund;
            }
        }
    }
}
