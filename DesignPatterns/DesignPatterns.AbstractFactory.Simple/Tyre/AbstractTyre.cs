using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory.Simple.Tyre
{
    public abstract class AbstractTyre : IMotorcycleTyre
    {
        protected AbstractTyre(int w, float a, int d, TyreLocation location)
        {
            TyreLocation = location;
            Width = w;
            Aspect = a;
            Diameter = d;
        }

        public ICollection<TyreCompound> TyreCompounds { get; set; }
        public TyreComposition TyreComposition { get; set; }
        public TyreLocation TyreLocation { get; set; }
        public TyreType TyreType { get; set; }
        public int Width { get; set; }
        public float Aspect { get; set; }
        public int Diameter { get; set; }
    }
}