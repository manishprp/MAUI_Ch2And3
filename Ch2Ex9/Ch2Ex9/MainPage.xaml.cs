namespace Ch2Ex9;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		var B =e.ToString();
		var image  = sender as ImageButton;
		if(image.Source == ImageSource.FromFile("new_heart"))
		{
			image.Source = ImageSource.FromFile("heart");
        }
		else
		{
			image.Source = ImageSource.FromFile("new_heart");
        }
    }
}

