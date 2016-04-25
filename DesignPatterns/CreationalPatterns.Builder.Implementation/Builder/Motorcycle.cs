using System;

namespace CreationalPatterns.Builder.Implementation.Builder
{
    public class Motorcycle
    {
        public string Name { get; set; }
        public string Chasis { get; set; }
        public string Engine { get; set; }
        public string FuelTank { get; set; }
        public string Suspension { get; set; }
        public string HeadAssembly { get; set; }
        public string TailAssembly { get; set; }

        public void PrintDetails()
        {
            string message = $"Motorcycle details for : {Name}";
            Console.WriteLine(message);
            message = $"Chasis : {Chasis}";
            Console.WriteLine(message);
            message = $"Engine : {Engine}";
            Console.WriteLine(message);
            message = $"FuelTank : {FuelTank}";
            Console.WriteLine(message);
            message = $"Suspension : {Suspension}";
            Console.WriteLine(message);
            message = $"HeadAssembly : {HeadAssembly}";
            Console.WriteLine(message);
            message = $"TailAssembly : {TailAssembly}";
            Console.WriteLine(message);
        }
    }
}