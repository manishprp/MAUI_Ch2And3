using Ch3Ex2.Convert;

namespace Ch3Ex2.DifferentUnits
{
    public class Fahrenheit : IConvert
    {
        public double FromValue { get; set; }
        public double Result { get; set; }
        public Units ToUnit { get; set; }

        public void Convert()
        {
            if (ToUnit == Units.Fahrenheit)
            {
                Result= FromValue;
            }
            else if (ToUnit == Units.Kelvin)
            {
                Result = (FromValue + 459.67) * 5 / 9;
            }
            else
            {
                Result = (FromValue - 32) * 5 / 9;
            }
        }
    }
}
