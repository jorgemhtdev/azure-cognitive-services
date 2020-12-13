namespace Quotes.Services
{
    using Quotes.Models;
    using Refit;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRefitApiService
    {
        [Post("/translate?api-version=3.0&to=en")]
        Task<ApiResponse<IEnumerable<Translate>>> GetTranslateAsync(object[] body);
    }
}
