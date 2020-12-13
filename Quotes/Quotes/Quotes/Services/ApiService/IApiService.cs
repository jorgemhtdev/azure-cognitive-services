namespace Quotes.Services
{
    using Quotes.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IApiService
    {
        IEnumerable<Quote> GetAllQuotes();
        Task<IEnumerable<Translate>> GetTranslateAsync(string text);
    }
}
