using System;
using CreationalPatterns.FactoryMethod.Implementation;
using CreationalPatterns.FactoryMethod.Implementation.Tyre;

namespace CreationalPatterns.FactoryMethod.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var mt09 = new YamahaMT09();
            var r1 = new YamahaR1();
            var r1M = new YamahaR1M();
            var xsr900 = new YamahaXSR900();

            Console.WriteLine("FactoryMethod Pattern");
            Console.WriteLine(mt09.MotorcycleTyreFront.GetType().Name);
            Console.WriteLine(r1.MotorcycleTyreFront.GetType().Name);
            Console.WriteLine(r1M.MotorcycleTyreFront.GetType().Name);
            Console.WriteLine(xsr900.MotorcycleTyreFront.GetType().Name);
            Console.WriteLine("Press any key to terminate FactoryMethod Pattern");
            Console.ReadKey();
        }
    }
}
