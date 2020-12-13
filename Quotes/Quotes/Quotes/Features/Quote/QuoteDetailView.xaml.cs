namespace Quotes.Features
{
    using Quotes.Models;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuoteDetailView : ContentPage
    {
        private Quote quote;

        public QuoteDetailView(Quote quote)
        {
            InitializeComponent();

            BindingContext = new QuoteViewModel();

            this.quote = quote;

            description.Text = quote.Description;
            author.Text = quote.Author;
        }
        private async void tapped_back(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void tapped_TranslateDescription(object sender, System.EventArgs e)
        {
            descriptionTranslate.Text = await(BindingContext as QuoteViewModel).Text(quote.Description);
        }
    }
}