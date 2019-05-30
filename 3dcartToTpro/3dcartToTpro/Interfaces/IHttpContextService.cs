using System.Collections.Specialized;
using System.Web;

namespace _3dcartToTpro.Interfaces
{
    public interface IHttpContextService
    {
        HttpContextBase Context { get; }
        HttpRequestBase Request { get; }
        HttpResponseBase Response { get; }
        NameValueCollection FormOrQuerystring { get; }
    }
}
