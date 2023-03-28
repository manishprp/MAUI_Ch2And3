using c3ex5.Model;
using c3ex5.ViewModel;

namespace c3ex5;

public partial class MainPage : ContentPage
{
	private readonly ShoppingViewModel _shoppingViewModel;

	public MainPage()
	{
		InitializeComponent();
		_shoppingViewModel = (ShoppingViewModel)BindingContext;
	}

	
}

