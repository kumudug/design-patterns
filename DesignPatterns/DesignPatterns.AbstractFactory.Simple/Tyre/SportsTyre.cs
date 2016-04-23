using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory.Simple.Tyre
{
    public class SportsTyre : AbstractTyre
    {
        public SportsTyre():base(0,0,0,TyreLocation.Front)
        {
            TyreType = TyreType.Sports;
        }

        public SportsTyre(int w, float a, int d, TyreLocation location) : base(w, a, d, location)
        {
            TyreType = TyreType.Sports;
            if (location == TyreLocation.Rear)
            {
                TyreCompounds = new List<TyreCompound> { TyreCompound.MediumHard, TyreCompound.SoftMedium, TyreCompound.Soft };
                TyreComposition = TyreComposition.TripleCompound;
            }
            else
            {
                TyreCompounds = new List<TyreCompound> { TyreCompound.Medium, TyreCompound.Soft };
                TyreComposition = TyreComposition.DuelCompound;
            }
        }
    }
}
