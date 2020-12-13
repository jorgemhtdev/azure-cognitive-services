[assembly: Xamarin.Forms.Dependency(typeof(Quotes.Services.ApiService))]
namespace Quotes.Services
{
    using Quotes.Models;
    using Refit;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ApiService : IApiService
    {
        public readonly IRefitApiService refitApiService;

        public ApiService()
        {
            HttpClient httpClient = new HttpClient(new CustomHttpClientHandler()) { BaseAddress = new Uri(ApiServiceKeys.ApiServiceBaseUrl) };
            refitApiService = RestService.For<IRefitApiService>(httpClient);
        }

        public IEnumerable<Quote> GetAllQuotes()
        {
            Task.Delay(TimeSpan.FromSeconds(5));

            return new List<Quote>
            {
                new Quote() { Description = "Aprende como si fueras a vivir toda la vida, y vive como si fueras a morir mañana",
                                Author = "Charlie Chaplin", Img = "charlie" },
                new Quote() { Description = "Nunca permitas que el sentido de la moral te impida hacer lo que está bien",
                                Author = "Isaac Asimov", Img = "george" },
                new Quote() { Description = "Para ser el rey de los conejos hay que ponerse las orejas largas",
                                Author = "George Raymond Richard Martin", Img = "isaac" },
            };
        }

        public async Task<IEnumerable<Translate>> GetTranslateAsync(string text)
        {
            var response = await refitApiService.GetTranslateAsync(new object[] { new { Text = text } });

            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content;
            else
                return null; // Lanzar una excepción
        }
    }
}
