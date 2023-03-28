using Ch3Ex2.Convert;
using Ch3Ex2.DifferentUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3Ex2.Model
{
    public class ConverterModel
    {
        private IConvert _convertObject;
        private Units _units;
        public bool ToFahrenheit { get; set; }
        public bool FromFahrenheit { get; set; }
        public bool ToKelvin { get; set; }
        public bool FromKelvin { get; set; }
        public bool ToCelsius { get; set; }
        public bool FromCelsius { get; set; }
        public double FromValue { get; set; }
        public double Result { get; set; }
        public ConverterModel() 
        {
            
        }
        public void ConvertTheValue()
        {
            var from = GetFromConvert();
            from.FromValue = FromValue;
            from.ToUnit = GetToConvert();
            from.Convert();
            Result = from.Result;
        }
        private IConvert GetFromConvert() 
        { 
            if(FromFahrenheit)
            {
                _convertObject = new Fahrenheit();
            }
            else if (FromCelsius)
            {
                _convertObject = new Celsius();
            }
            else
            {
                _convertObject = new Kelvin();
            }
            return _convertObject;
        }
        private Units GetToConvert()
        {
            if (ToFahrenheit)
            {
                _units = Units.Fahrenheit;
            }
            else if (ToCelsius)
            {
                _units= Units.Celsius;
            }
            else
            {
                _units= Units.Kelvin;
            }
            return _units;
        }
    }
}
