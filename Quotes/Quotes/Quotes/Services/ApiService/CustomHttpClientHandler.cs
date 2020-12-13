namespace Quotes.Services
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    internal class CustomHttpClientHandler : HttpClientHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Ocp-Apim-Subscription-Key", ApiServiceKeys.Key);
            request.Headers.Add("Ocp-Apim-Subscription-Region", "westeurope");

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
