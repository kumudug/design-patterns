using System.Collections.Generic;
using DesignPatterns.AbstractFactory.Simple.Tyre;

namespace DesignPatterns.AbstractFactory.Simple
{
    public class BridgestoneTyreFactory: AbstractTyreFactory
    {
        public override SportsTyre CreateSportsTyre(int w, float a, int d, TyreLocation location)
        {
            var tyre = base.CreateSportsTyre(w, a, d, location);

            if (location == TyreLocation.Rear)
            {
                if (w > 100)
                {
                    tyre.TyreCompounds = new List<TyreCompound>()
                    {
                        TyreCompound.Medium,
                        TyreCompound.SoftMedium,
                        TyreCompound.Soft
                    };
                    tyre.TyreComposition = TyreComposition.TripleCompound;
                }
                else
                {
                    tyre.TyreCompounds = new List<TyreCompound>()
                    {
                        TyreCompound.Medium,
                        TyreCompound.Soft
                    };
                    tyre.TyreComposition = TyreComposition.DuelCompound;
                }
            }

            return tyre;
        }
    }
}
