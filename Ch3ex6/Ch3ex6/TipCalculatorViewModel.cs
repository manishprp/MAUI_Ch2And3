using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Ch3ex6.ViewModel
{
    class TipCalculatorViewModel : INotifyPropertyChanged
    {
        private TipCalculatorModel _tipCalculatorModel;
        public double Amount { get; set; }
        private int _tipPercentage;
        public int TipPercenrage 
        { get { return _tipPercentage; }
            
          set {
                _tipPercentage = value;
                    NotifyPropertyChanged(); } 
        }
        private int _splitBetween;
        public int SplitBetween 
        {
            get { return _splitBetween; }

            set
            {
                _splitBetween = value;
                NotifyPropertyChanged();
            }
        }
        private double _tip;
        private double _total;
        public double Tip {
            get { return _tip; }

            set
            {
                _tip = value;
                NotifyPropertyChanged();
            }
        }


        public double Total {
            get { return _total; }

            set
            {
                _total = value;
                NotifyPropertyChanged();
            }
        }
        private double _perPersonCost;
        public double PerPersonCost
        {
            get { return _perPersonCost; }
            set
            {
                _perPersonCost = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand TipChangeCommand { get; private set; }

        public TipCalculatorViewModel()
        {
            _tipCalculatorModel = new TipCalculatorModel();
            TipChangeCommand = new Command(TipChange);
        }

        

        private void TipChange(object obj)
        {
            _tipCalculatorModel.TipPercenrage = TipPercenrage;
            _tipCalculatorModel.Amount = Amount;
            _tipCalculatorModel.SplitBetween = SplitBetween;
            _tipCalculatorModel.CalculateTotal();
            Total = _tipCalculatorModel.Total;
            Tip = _tipCalculatorModel.Tip;
            PerPersonCost = _tipCalculatorModel.PerPersonCost;
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
