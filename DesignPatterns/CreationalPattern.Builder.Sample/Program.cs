using System;
using CreationalPatterns.Builder.Implementation;
using CreationalPatterns.Builder.Implementation.Builder;

namespace CreationalPattern.Builder.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var productionLine = new MotorcycleProductionLine();
            // ReSharper disable once InconsistentNaming
            var builderMT09 = new MotorcycleMT09Builder();
            // ReSharper disable once InconsistentNaming
            var builderXSR900 = new MotorcycleXSR900Builder();
            Console.WriteLine("----------------------Build MT09----------------------");
            productionLine.BuildMotorcycle(builderMT09);
            Console.WriteLine("----------------------Build XSR900----------------------");
            productionLine.BuildMotorcycle(builderXSR900);
            Console.ReadKey();
        }
    }
}
