using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory.Simple.Tyre
{
    public class DuelSportsTyre : AbstractTyre
    {
        public DuelSportsTyre():base(0,0,0,TyreLocation.Front)
        {
            TyreType = TyreType.DuelSports;
        }

        public DuelSportsTyre(int w, float a, int d, TyreLocation location) : base(w, a, d, location)
        {
            TyreType = TyreType.DuelSports;
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
