namespace Ch3ex6
{
    class TipCalculatorModel
    {
        public double Amount { get; set; }
        public double PerPersonCost { get; set; }
        public int TipPercenrage { get; set; }
        public int SplitBetween { get; set; }
        public double Tip { get; set; }
        public double Total { get; set; }
      
        public void CalculateTotal()
        {
            double per = TipPercenrage / 100.00;
            Tip = per * Amount;
            Total = Amount + Tip;
            PerPersonCost = Total / SplitBetween;
        }
    }
}
