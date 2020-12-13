namespace Quotes.Features
{
    using Quotes.Models;
    using Quotes.Services;
    using Refit;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Xamarin.Forms;

    public class QuoteViewModel
    {
        public IEnumerable<Quote> GetQuotes()
        {
            // IsBusy TryCatch Etc
            return DependencyService.Get<IApiService>().GetAllQuotes();
        }

        public async Task<string> Text(string description)
        {           
            // IsBusy TryCatch Etc
            IEnumerable<Translate> translate = await DependencyService.Get<IApiService>().GetTranslateAsync(description);

            return translate.FirstOrDefault().Translations.FirstOrDefault().Text;
        }
    }
}
