using Ch3Ex1.ViewModel;

namespace Ch3Ex1;

public partial class MainPage : ContentPage
{
	private readonly QuoteAppViewModel _quoteAppViewModel;
	public MainPage()
	{
		InitializeComponent();
		_quoteAppViewModel = (QuoteAppViewModel)BindingContext;

    }
}

