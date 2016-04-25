namespace CreationalPatterns.FactoryMethod.Implementation.Tyre
{
    public class DunlopMotorcycleTyre : IMotorcycleTyre
    {
        public DunlopMotorcycleTyre(int width, float aspect, int diameter)
        {
            Width = width;
            Aspect = aspect;
            Diameter = diameter;
        }

        public int Width { get; set; }
        public float Aspect { get; set; }
        public int Diameter { get; set; }
    }
}
