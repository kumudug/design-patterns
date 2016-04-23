using DesignPatterns.AbstractFactory.Simple.Factory;
using DesignPatterns.AbstractFactory.Simple.Tyre;

namespace DesignPatterns.AbstractFactory.Simple
{
    public abstract class AbstractMotorcycle
    {
        public IMotorcycleTyre FrontTyre { get; set; }
        public IMotorcycleTyre RearTyre { get; set; }

        protected AbstractMotorcycle(IMotorcycleTyreFactory tyreFactory){}
    }
}
