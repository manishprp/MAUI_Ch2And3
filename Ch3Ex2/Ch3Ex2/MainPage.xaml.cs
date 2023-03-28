using Ch3Ex2.ViewModel;

namespace Ch3Ex2;

public partial class MainPage : ContentPage
{
	private readonly ConverterViewModel _converterViewModel;
	public MainPage()
	{
		InitializeComponent();
        _converterViewModel = (ConverterViewModel)BindingContext;

    }
    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        _converterViewModel.ConvertCommand.Execute(this);
    }
}

