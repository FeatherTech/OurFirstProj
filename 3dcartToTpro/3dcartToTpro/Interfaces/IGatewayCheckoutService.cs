using _3dcartToTpro.Models.Cart;
using _3dcartToTpro.Models.Gateway;

namespace _3dcartToTpro.Interfaces
{
    public interface IGatewayCheckoutService
    {
        GatewayCheckoutResponse InitiateGatewayChechout(CheckoutRequest request, GatewayToken token);
        GatewayOrderDetails GetGatewayOrderDetails(string reference_id, GatewayToken token);
    }
}
