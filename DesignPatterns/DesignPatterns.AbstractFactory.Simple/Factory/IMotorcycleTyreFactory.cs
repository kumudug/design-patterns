using DesignPatterns.AbstractFactory.Simple.Tyre;

namespace DesignPatterns.AbstractFactory.Simple.Factory
{
    public interface IMotorcycleTyreFactory
    {
        SportsTyre CreateSportsTyre(int w, float a, int d, TyreLocation location);
        TouringTyre CreateTouringTyre(int w, float a, int d, TyreLocation location);
        SportsTouringTyre CreateSportsTouringTyre(int w, float a, int d, TyreLocation location);
        TrackTyre CreateTrackTyre(int w, float a, int d, TyreLocation location);
        CruiserTyre CreateCruiserTyre(int w, float a, int d, TyreLocation location);
        DuelSportsTyre CreateDuelSportsTyre(int w, float a, int d, TyreLocation location);
        DirtTyre CreateDirtTyre(int w, float a, int d, TyreLocation location);
    }
}