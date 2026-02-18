using DesignPatternChallenge_AbstractFactory.AbstractFactory;
using DesignPatternChallenge_AbstractFactory.AbstractProducts;
using DesignPatternChallenge_AbstractFactory.ConcreteProducts.MercadoPago;

namespace DesignPatternChallenge_AbstractFactory.ConcreteFactories
{
    internal class MercadoPagoPaymentFactory : IPaymentProviderFactory
    {
        public IProcessor CreateProcessor()
        {
            return new MercadoPagoProcessor();
        }

        public IValidator CreateValidator()
        {
            return new MercadoPagoValidator();
        }

        public ILogger CreateLogger()
        {
            return new MercadoPagoLogger();
        }
    }
}
