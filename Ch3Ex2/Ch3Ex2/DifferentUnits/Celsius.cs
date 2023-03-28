using Ch3Ex2.Convert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3Ex2.DifferentUnits
{
    public class Celsius : IConvert
    {
        public double FromValue { get; set; }
        public double Result { get; set; }
        public Units ToUnit { get; set; }

        public void Convert()
        {
            if (ToUnit == Units.Celsius)
            {
                Result = FromValue;
            }
            else if (ToUnit == Units.Kelvin)
            {
                Result = FromValue + 273.15;

            }
            else
            {
                Result = (FromValue * 9 / 5) + 32;

            }
        }
    }
}
