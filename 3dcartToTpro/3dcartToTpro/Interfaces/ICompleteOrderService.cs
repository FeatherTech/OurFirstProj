using _3dcartToTpro.Models.Cart;
using _3dcartToTpro.Models.Gateway;

namespace _3dcartToTpro.Interfaces
{
    public interface ICompleteOrderService
    {
        CheckoutRequest GetCurrentRequest(int id);
        bool CompleteOrder(int approved, string errorcode, string errormessage, CheckoutRequest request, GatewayOrderDetails gatewayOrderDetails);
        bool UpdateRequest(int id, Status newstatus);
        void DelayExecution(int seconds);
    }
}
