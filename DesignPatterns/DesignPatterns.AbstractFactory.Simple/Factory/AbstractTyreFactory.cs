using DesignPatterns.AbstractFactory.Simple.Tyre;

namespace DesignPatterns.AbstractFactory.Simple.Factory
{
    public abstract class AbstractTyreFactory : IMotorcycleTyreFactory
    {
        public virtual SportsTyre CreateSportsTyre(int w, float a, int d, TyreLocation location)
        {
            return new SportsTyre(w, a, d, location);
        }

        public virtual TouringTyre CreateTouringTyre(int w, float a, int d, TyreLocation location)
        {
            return new TouringTyre(w, a, d, location);
        }

        public virtual SportsTouringTyre CreateSportsTouringTyre(int w, float a, int d, TyreLocation location)
        {
            return new SportsTouringTyre(w, a, d, location);
        }

        public virtual TrackTyre CreateTrackTyre(int w, float a, int d, TyreLocation location)
        {
            return new TrackTyre(w, a, d, location);
        }

        public virtual CruiserTyre CreateCruiserTyre(int w, float a, int d, TyreLocation location)
        {
            return new CruiserTyre(w, a, d, location);
        }

        public virtual DuelSportsTyre CreateDuelSportsTyre(int w, float a, int d, TyreLocation location)
        {
            return new DuelSportsTyre(w, a, d, location);
        }

        public virtual DirtTyre CreateDirtTyre(int w, float a, int d, TyreLocation location)
        {
            return new DirtTyre(w, a, d, location);
        }
    }
}