using DesignPatternChallenge_AbstractFactory.AbstractFactory;

namespace DesignPatternChallenge_AbstractFactory
{
    internal class PaymentService(IPaymentProviderFactory factory)
    {
        private readonly IPaymentProviderFactory _paymentProviderFactory =
            factory ?? throw new ArgumentNullException(nameof(factory));

        public void ProcessPayment(decimal amount, string cardNumber)
        {
            var validator = _paymentProviderFactory.CreateValidator();
            if (!validator.ValidateCard(cardNumber))
            {
                Console.WriteLine($"{_paymentProviderFactory.GetType().Name}: Cartão inválido");
                return;
            }

            var processor = _paymentProviderFactory.CreateProcessor();
            var result = processor.ProcessTransaction(amount, cardNumber);

            var logger = _paymentProviderFactory.CreateLogger();
            logger.Log($"Transação processada: {result}");
        }
    }
}
