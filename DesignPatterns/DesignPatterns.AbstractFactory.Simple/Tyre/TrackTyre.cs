using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory.Simple.Tyre
{
    public class TrackTyre : AbstractTyre
    {
        public TrackTyre() : base(0, 0, 0, TyreLocation.Front)
        {
            TyreType = TyreType.Track;
        }

        public TrackTyre(int w, float a, int d, TyreLocation location) : base(w, a, d, location)
        {
            TyreType = TyreType.Track;
            if (location == TyreLocation.Rear)
            {
                TyreCompounds = new List<TyreCompound> {TyreCompound.Medium, TyreCompound.SoftMedium, TyreCompound.Soft};
                TyreComposition = TyreComposition.TripleCompound;
            }
            else
            {
                TyreCompounds = new List<TyreCompound> {TyreCompound.Soft};
                TyreComposition = TyreComposition.SingleCompund;
            }
        }
    }
}