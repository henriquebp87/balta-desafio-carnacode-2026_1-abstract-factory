using DesignPatternChallenge_AbstractFactory.AbstractFactory;
using DesignPatternChallenge_AbstractFactory.AbstractProducts;
using DesignPatternChallenge_AbstractFactory.ConcreteProducts.Stripe;

namespace DesignPatternChallenge_AbstractFactory.ConcreteFactories
{
    internal class StripePaymentFactory : IPaymentProviderFactory
    {
        public IProcessor CreateProcessor()
        {
            return new StripeProcessor();
        }

        public IValidator CreateValidator()
        {
            return new StripeValidator();
        }

        public ILogger CreateLogger()
        {
            return new StripeLogger();
        }
    }
}
