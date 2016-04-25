namespace CreationalPatterns.FactoryMethod.Implementation.Tyre
{
    public class BridgestoneMotorcycleTyre : IMotorcycleTyre
    {
        public BridgestoneMotorcycleTyre(int width, float aspect, int diameter)
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
