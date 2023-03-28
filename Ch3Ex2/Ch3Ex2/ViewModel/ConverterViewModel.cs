using Ch3Ex2.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Ch3Ex2.ViewModel
{
    public class ConverterViewModel : INotifyPropertyChanged
    {
        private ConverterModel _converterModel;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool ToFahrenheit { get; set; }
        public bool FromFahrenheit { get; set; }
        public bool ToKelvin { get; set; }
        public bool FromKelvin { get; set; }
        public bool ToCelsius { get; set; }
        public bool FromCelsius { get; set; }
        public double FromValue { get; set; }
        private double _result;
        public double Result
        {
            get { return _result; }
            set 
            {
                _result = value;
                INotifyPropertyChanged();
            }
        }

        public ICommand ConvertCommand { get; private set; }
        public ConverterViewModel()
        {
            _converterModel = new ConverterModel();
            ConvertCommand = new Command(ConvertValues);
        }

        private void ConvertValues()
        {
            _converterModel.ToFahrenheit= ToFahrenheit;
            _converterModel.ToCelsius  = ToCelsius;
            _converterModel.ToKelvin= ToKelvin;
            _converterModel.FromCelsius= FromCelsius;
            _converterModel.FromFahrenheit= FromFahrenheit;
            _converterModel.FromKelvin= FromKelvin;
            _converterModel.FromValue= FromValue;
            _converterModel.ConvertTheValue();
            Result = _converterModel.Result;
        }
        private void INotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
