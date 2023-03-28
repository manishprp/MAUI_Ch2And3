using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Ch3Ex7.ViewModel
{
    public class ColorPickerViewModel :INotifyPropertyChanged
    {
        private ColorPickerModel _colorPickerModel;

        public event PropertyChangedEventHandler PropertyChanged;

        private byte _redValue;
        public byte RedValue
        {
            get { return _redValue; }
            set
            {
                _redValue = value;
                NotifyPropertyChanged();
            }
        }
        private byte _greenValue;
        public byte GreenValue {
            get { return _greenValue; }
            set
            {
                _greenValue = value;
                NotifyPropertyChanged();
            }
        }
        private byte _blueValue;
        public byte BlueValue {
            get { return _blueValue; }
            set
            {
                _blueValue = value;
                NotifyPropertyChanged();
            }
        }
        private string _hexColorCode;
        public string HexColorCode 
        { get { return _hexColorCode; }
          set { _hexColorCode = value;
                NotifyPropertyChanged();
            }
            
        }
        private Color _color;
        public Color Color {
            get { return _color; }
            set { _color = value;
            NotifyPropertyChanged();
        }
            
        }
        public ICommand ColorChangeCommand { get; private set; }
        public ICommand GetRandomColorCommand { get; private set; }

        public ColorPickerViewModel()
        {
            _colorPickerModel = new ColorPickerModel();
            ColorChangeCommand = new Command(ChangeColor);
            GetRandomColorCommand = new Command(GetRandomColor);
            
        }
        private void NotifyPropertyChanged([CallerMemberName] string propertyname ="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
        private void ChangeColor(object obj)
        {
            _colorPickerModel.RedValue = RedValue;
            _colorPickerModel.BlueValue = BlueValue;
            _colorPickerModel.GreenValue = GreenValue;
            _colorPickerModel.ChangeColor();
            HexColorCode= _colorPickerModel.HexColorCode;
            Color = _colorPickerModel.Color;
        }

        private void GetRandomColor(object obj)
        {
            _colorPickerModel.GetRandomColor();
            RedValue= _colorPickerModel.RedValue;
            GreenValue= _colorPickerModel.GreenValue;
            BlueValue= _colorPickerModel.BlueValue;
            HexColorCode= _colorPickerModel.HexColorCode;
            Color = _colorPickerModel.Color;
        }
    }
}
