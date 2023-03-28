using Ch3Ex2.Convert;

namespace Ch3Ex2.DifferentUnits
{
    public class Kelvin : IConvert
    {
        public double FromValue { get; set; }
        public double Result { get; set; }
        public Units ToUnit { get; set; }

        public void Convert()
        {
            if (ToUnit == Units.Kelvin)
            {
                Result= FromValue;
            }
            else if (ToUnit == Units.Fahrenheit)
            {
                Result = (FromValue - 273.15) * 9 / 5 + 32;

            }
            else
            {
                Result = FromValue - 273.15;
            }
        }
    }
}
