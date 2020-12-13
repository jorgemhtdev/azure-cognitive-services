namespace Quotes.Features
{
    using Quotes.Models;
    using System.Linq;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuoteView : ContentPage
    {
        public QuoteView()
        {
            InitializeComponent();

            BindingContext = new QuoteViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            collectionViewQuotes.ItemsSource = (BindingContext as QuoteViewModel).GetQuotes();
        }

        private void selectionQuote(object sender, SelectionChangedEventArgs e)
        {
            Quote quote = (e.CurrentSelection.FirstOrDefault() as Quote);

            if (quote is Quote)
            {
                App.Current.MainPage.Navigation.PushAsync(new QuoteDetailView(quote));
            }
        }
    }
}