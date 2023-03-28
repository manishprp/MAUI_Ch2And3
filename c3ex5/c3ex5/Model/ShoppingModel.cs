namespace c3ex5.Model
{
    class ShoppingModel
    {
        private readonly double PriceOne = 3.55;
        private readonly double PriceTwo=6.99;
        private readonly double PriceThree=1.23;
        private readonly string _promoCode = "1Rivet";
        private WhichButtonPressed _whichButtonPressed;
        public bool IfPromocodeApplied;
        public string ModelButtonType { get; set; }
        public bool RadioButtonOne { get; set; }
        public bool RadioButtonTwo { get; set; }
        public bool RadioButtonThree { get; set; }
        public int QuantityOne { get; set; }
        public int QuantityTwo { get; set; }
        public int QuantityThree { get; set; }
        public double TotalPriceOne { get; set; }
        public double TotalPriceTwo { get; set; }
        public double TotalPriceThree { get; set; }
        public double SubTotalPrice { get; set; }
        public double TotalPrice { get; set; }
        public int TotalItems { get; set; }
        public double ShippingPrice { get; private set; } = 2.99;
        public string PromoCode { get; set; }
        public ShoppingModel()
        {
            _whichButtonPressed = new WhichButtonPressed();
        }
        public void Increement()
        {
            if(ButtonIdentifier.IncreementOne== _whichButtonPressed.WhichButton(ModelButtonType))
            {
                QuantityOne++;
                TotalPriceOne = PriceOne * QuantityOne;
                ValueChanged();
            }
            else if(ButtonIdentifier.IncreementTwo == _whichButtonPressed.WhichButton(ModelButtonType))
            {
                QuantityTwo++;
                TotalPriceTwo = PriceTwo * QuantityTwo;
                ValueChanged();
            }
            else
            {
                QuantityThree++;
                TotalPriceThree = PriceThree * QuantityThree;
                ValueChanged();
            }
        }
        public void Decreement()
        {
            if (ButtonIdentifier.DecreementOne == _whichButtonPressed.WhichButton(ModelButtonType))
            {
                if(QuantityOne>0)
                {
                    QuantityOne--;
                    TotalPriceOne = PriceOne * QuantityOne;
                    ValueChanged();
                }
            }
            else if (ButtonIdentifier.DecreementTwo == _whichButtonPressed.WhichButton(ModelButtonType))
            {
                if (QuantityTwo > 0)
                {
                    QuantityTwo--;
                    TotalPriceTwo = PriceTwo * QuantityTwo;
                    ValueChanged();
                    
                }
            }
            else
            {
                if (QuantityThree > 0)
                {
                    QuantityThree--;
                    TotalPriceThree = PriceThree * QuantityThree;
                    ValueChanged();
                }
            }
        }
        private void ValueChanged()
        {
            SubtotalCalculate();
            if (SubTotalPrice==0)
            TotalPrice = SubTotalPrice;
            else
            TotalPrice = SubTotalPrice + ShippingPrice;
            TotalItems = QuantityOne+ QuantityTwo + QuantityThree;
        }
        public void ApplyPromocode()
        {
            ValueChanged();
        }

        private void SubtotalCalculate()
        {
            SubTotalPrice = TotalPriceOne + TotalPriceTwo + TotalPriceThree;
            if (_promoCode == PromoCode)
            {
                var subtotal = SubTotalPrice - (0.1 * SubTotalPrice);
                SubTotalPrice = subtotal;
                IfPromocodeApplied = true;
            }
            else
            {
                IfPromocodeApplied = false;
                return;
                
            }
        }
    }
}
