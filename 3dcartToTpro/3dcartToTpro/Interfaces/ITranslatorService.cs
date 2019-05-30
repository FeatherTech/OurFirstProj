using _3dcartToTpro.Models.Cart;
using _3dcartToTpro.Models.Gateway;

namespace _3dcartToTpro.Interfaces
{
    public interface ITranslatorService
    {
        GatewayCheckoutRequest GetGatewayCheckoutRequest(CheckoutRequest request);

        GatewayRefundRequest GetGatewayRefundRequest(RefundRequest request);
    }
}
