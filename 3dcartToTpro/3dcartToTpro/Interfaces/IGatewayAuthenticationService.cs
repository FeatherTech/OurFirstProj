using _3dcartToTpro.Models.Gateway;

namespace _3dcartToTpro.Interfaces
{
    public interface IGatewayAuthenticationService
    {
        GatewayToken GetGatewayToken(string user, string password);
    }
}
