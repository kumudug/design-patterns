using DesignPatterns.AbstractFactory.Simple;

namespace DesignPatterns.AbstractFactory.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var mt09 = new Motorcycle_MT09(new BridgestoneTyreFactory());
        }
    }
}
