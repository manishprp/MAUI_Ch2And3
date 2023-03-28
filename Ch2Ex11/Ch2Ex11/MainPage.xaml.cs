namespace Ch2Ex11;

public partial class MainPage : ContentPage
{
    private int _temperature = 1;
	public MainPage()
	{
		InitializeComponent();
        TempBig.Text = _temperature.ToString() + "°";
        TempSmall.Text = _temperature.ToString() + "°C";
        SetBackgroundOnTemp();
    }

    private void ImageDown_Clicked(object sender, EventArgs e)
    {
        if(_temperature==1)
        {
            return;
        }
        else
        {
            _temperature--;
            SetBackgroundOnTemp();
            TempBig.Text = _temperature.ToString() + "°";
            TempSmall.Text = _temperature.ToString() + "°C";
        }

    }

    private void ImageUp_Clicked(object sender, EventArgs e)
    {
            if (_temperature == 40)
            {
                return;
            }
            else
            {
                _temperature++;
                SetBackgroundOnTemp();
                TempBig.Text = _temperature.ToString() + "°";
                TempSmall.Text = _temperature.ToString() + "°C";
            }
        

    }
    private void SetBackgroundOnTemp() 
    {
        if(_temperature>=1&&_temperature<=10)
        {
            StackLayoutBackground.BackgroundColor =Color.FromRgb(47,87,148);
        }
        else if(_temperature >= 11 && _temperature <= 20)
        {
            StackLayoutBackground.BackgroundColor = Color.FromRgb(255, 255, 0);
        }
        else if (_temperature >= 21 && _temperature <= 30)
        {
            StackLayoutBackground.BackgroundColor = Color.FromRgb(241, 90, 34);
        }
        else
        {
            StackLayoutBackground.BackgroundColor = Color.FromRgb(255, 0, 0);
        }
    }
}

