// DESAFIO: Sistema de Pagamentos Multi-Gateway
// PROBLEMA: Uma plataforma de e-commerce precisa integrar com múltiplos gateways de pagamento
// (PagSeguro, MercadoPago, Stripe) e cada gateway tem componentes específicos (Processador, Validador, Logger)
// O código anterior estava muito acoplado e dificultava a adição de novos gateways.

using DesignPatternChallenge_AbstractFactory.AbstractFactory;

namespace DesignPatternChallenge_AbstractFactory;

public class Program
{
    // Contexto: Sistema de pagamentos que precisa trabalhar com diferentes gateways
    // Cada gateway tem sua própria forma de processar, validar e logar transações

    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Pagamentos ===\n");

        var factory = BuildFactory("pagseguro");
        var pagSeguroService = new PaymentService(factory);
        pagSeguroService.ProcessPayment(150.00m, "1234567890123456");

        Console.WriteLine();

        factory = BuildFactory("mercadopago");
        var mercadoPagoService = new PaymentService(factory);
        mercadoPagoService.ProcessPayment(200.00m, "5234567890123456");

        Console.WriteLine();
    }

    private static IPaymentProviderFactory BuildFactory(string provider)
    {
        return provider.ToLower() switch
        {
            "pagseguro" => new ConcreteFactories.PagSeguroPaymentFactory(),
            "mercadopago" => new ConcreteFactories.MercadoPagoPaymentFactory(),
            "stripe" => new ConcreteFactories.StripePaymentFactory(),
            _ => throw new ArgumentException("Gateway de pagamento desconhecido.")
        };
    }
}