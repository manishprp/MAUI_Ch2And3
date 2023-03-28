using c3ex5.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace c3ex5.ViewModel
{
    class ShoppingViewModel : INotifyPropertyChanged
    {
        // whichButton
        public string ButtonType { get; set; }
        //
        private ShoppingModel _shoppingModel;
        public bool RadioButtonOne { get; set; }
        public bool RadioButtonTwo { get; set; }
        public bool RadioButtonThree { get; set; }

        private int _quantityOne;
        public int QuantityOne {
            get
            {
                return _quantityOne;
            }
            private set
            {
                _quantityOne = value;
                NotifyPropertychanged();
            }
        }
        private int _quantityTwo;
        public int QuantityTwo {
            get
            {
                return _quantityTwo;
            }
            private set
            {
                _quantityTwo = value;
                NotifyPropertychanged();
            }
        }
        private int _quantityThree;
        public int QuantityThree {
            get
            {
                return _quantityThree;
            }
            private set
            {
                _quantityThree = value;
                NotifyPropertychanged();
            }
        }

        private double _totalPriceOne;
        public double TotalPriceOne
        {
            get
            {
                return _totalPriceOne;
            }
            private set
            {
                _totalPriceOne = Math.Round(value,2);
                NotifyPropertychanged();
            }
        }
        private double _totalPriceTwo;
        public double TotalPriceTwo {
            get
            {
                return _totalPriceTwo;
            }
            private set
            {
                _totalPriceTwo = Math.Round(value,2);
                NotifyPropertychanged();
            }
        }
        private double _totalPriceThree;
        public double TotalPriceThree
        {
            get
            {
                return _totalPriceThree;
            }
            private set
            {
                _totalPriceThree = Math.Round(value, 2);
                NotifyPropertychanged();
            }
        }
        private double _subTotalPrice;
        public double SubTotalPrice
        {
            get
            {
                return _subTotalPrice;
            }
            private set
            {
                _subTotalPrice = Math.Round(value, 2);
                NotifyPropertychanged();
            }
        }
        private double _totalPrice;
        public double TotalPrice {
            get
            {
                return _totalPrice;
            }
            private set
            {
                _totalPrice = Math.Round(value, 2);
                NotifyPropertychanged();
            }
        }

        private int _totalItems;
        public int TotalItems {
            get
            {
                return _totalItems;
            }
            private set
            {
                _totalItems = value;
                NotifyPropertychanged();
            }
        }
        
        private double _shippingPrice;
        public double ShippingPrice 
        {
            get 
            {
                return _shippingPrice; 
            }
            private set 
            {   
                _shippingPrice = value;
                NotifyPropertychanged();
            }
        }
        public string PromoCode { get; set;}

        public ICommand DecreementCommand { get; private set; }
        public ICommand IncreementCommand { get; private set; }
        public ICommand CheckBoxChangedCommand { get; private set; }
        public ICommand ApplyPromocodeCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public ShoppingViewModel()
        {
            DecreementCommand = new Command<string>(Decreement);
            IncreementCommand = new Command<string>(Increement);
            CheckBoxChangedCommand = new Command(CheckBoxChanged);
            ApplyPromocodeCommand = new Command(ApplyCode,EnableButton);
            _shoppingModel = new ShoppingModel();
            ShippingPrice = _shoppingModel.ShippingPrice;
        }

   

        private void ApplyCode(object obj)
        {
             _shoppingModel.PromoCode = PromoCode;
            _shoppingModel.ApplyPromocode();
            FetchValues();
            RefreshCanExecute();
        }

        private void RefreshCanExecute()
        {
            ((Command)ApplyPromocodeCommand).ChangeCanExecute();
        }

        private bool EnableButton(object arg)
        {
            if(_shoppingModel.IfPromocodeApplied)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Increement(string obj)
        {
            ButtonType = obj;
            _shoppingModel.ModelButtonType = ButtonType;
            _shoppingModel.Increement();
            FetchValues();
        }

        private void FetchValues()
        {
            QuantityOne = _shoppingModel.QuantityOne;
            QuantityTwo = _shoppingModel.QuantityTwo;
            QuantityThree = _shoppingModel.QuantityThree;
            TotalPriceOne= _shoppingModel.TotalPriceOne;
            TotalPriceTwo= _shoppingModel.TotalPriceTwo;
            TotalPriceThree= _shoppingModel.TotalPriceThree;
            SubTotalPrice = _shoppingModel.SubTotalPrice;
            TotalPrice= _shoppingModel.TotalPrice;
            TotalItems= _shoppingModel.TotalItems;
        }

        private void Decreement(string obj)
        {
            ButtonType = obj;
            _shoppingModel.ModelButtonType= ButtonType;
            _shoppingModel.Decreement();
            FetchValues();
        }

        private void NotifyPropertychanged([CallerMemberName] string PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private void CheckBoxChanged()
        {

        }
       
    }
}
