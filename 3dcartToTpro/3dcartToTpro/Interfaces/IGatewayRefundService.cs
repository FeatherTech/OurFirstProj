using _3dcartToTpro.Models.Cart;
using _3dcartToTpro.Models.Gateway;

namespace _3dcartToTpro.Interfaces
{
    public interface IGatewayRefundService
    {
        GatewayRefundResponse InitiateGatewayRefund(RefundRequest request, GatewayToken token);
    }
}
