namespace CreationalPatterns.FactoryMethod.Implementation.Tyre
{
    public class MichelinMotorcycleTyre : IMotorcycleTyre
    {
        public MichelinMotorcycleTyre(int width, float aspect, int diameter) 
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
