namespace Ch3Ex2.Convert
{
    public interface IConvert
    {
        public double FromValue { get; set; }
        public double Result { get; set; }
        public Units ToUnit { get; set; }
        public void Convert();
    }
}
