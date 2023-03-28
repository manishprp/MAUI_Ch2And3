namespace Ch3Ex7
{
    public class ColorPickerModel
    {
        private Random _random;
        public byte RedValue { get; set; }
        public byte GreenValue { get; set; }
        public byte BlueValue { get; set; }
        public string HexColorCode { get; set; }
        public Color Color;
        public ColorPickerModel()
        {
            _random = new Random();
        }

        public void ChangeColor()
        {
            HexColorCode = "#"+RedValue.ToString("X2") + BlueValue.ToString("X2") + GreenValue.ToString("X2");
            Color = Color.FromArgb(HexColorCode);
        }
        public void GetRandomColor()
        {
            RedValue = Convert.ToByte( _random.Next(0,255));
            GreenValue = Convert.ToByte( _random.Next(0,255));
            BlueValue = Convert.ToByte( _random.Next(0,255));
            HexColorCode = "#" + RedValue.ToString("X2") + BlueValue.ToString("X2") + GreenValue.ToString("X2");
            Color = Color.FromArgb(HexColorCode);
        }
    }
}
