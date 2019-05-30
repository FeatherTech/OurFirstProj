using _3dcartToTpro.Models.Gateway;

namespace _3dcartToTpro.Interfaces
{
    public interface ICacheTokenHandlerService
    {
        GatewayToken GetTokenFromCache(string cacheKey);
        bool CachingValidToken(string cacheKey, GatewayToken authToken);
    }
}
