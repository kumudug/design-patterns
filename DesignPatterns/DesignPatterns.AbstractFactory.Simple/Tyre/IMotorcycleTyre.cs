using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory.Simple.Tyre
{
    public interface IMotorcycleTyre
    {
        ICollection<TyreCompound> TyreCompounds { get; set; }
        TyreComposition TyreComposition { get; set; }
        TyreLocation TyreLocation { get; set; }
        TyreType TyreType { get; set; }
        int Width { get; set; }
        float Aspect { get; set; }
        int Diameter { get; set; }
    }
}
