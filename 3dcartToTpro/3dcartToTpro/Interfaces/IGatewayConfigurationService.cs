using _3dcartToTpro.Models.Gateway;

namespace _3dcartToTpro.Interfaces
{
    public interface IGatewayConfigurationService
    {
        bool SetWebhook(string baseUrl, GatewayToken authToken);
    }
}
