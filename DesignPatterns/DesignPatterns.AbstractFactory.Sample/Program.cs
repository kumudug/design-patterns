using System;
using DesignPatterns.AbstractFactory.Simple;
using DesignPatterns.AbstractFactory.Simple.Factory;

namespace DesignPatterns.AbstractFactory.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var mt09 = new YamahaMT09(new BridgestoneTyreFactory());
            var r1 = new YamahaR1(new DunlopTyreFactory());
            var r1M = new YamahaR1M(new MichelinTyreFactory());
            var xsr900 = new YamahaXSR900(new PirelliTyreFactory());

            Console.WriteLine("AbstractFactory Pattern");
            Console.WriteLine(mt09.FrontTyre.GetType().Name);
            Console.WriteLine(r1.FrontTyre.GetType().Name);
            Console.WriteLine(r1M.FrontTyre.GetType().Name);
            Console.WriteLine(xsr900.FrontTyre.GetType().Name);
            Console.WriteLine("Press any key to terminate AbstractFactory Pattern");
            Console.ReadKey();
        }
    }
}
