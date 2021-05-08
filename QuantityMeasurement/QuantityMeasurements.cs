/////------------------------------------------------------------------------
////<copyright file="QuantityMeasurements.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------
namespace QuantityMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Quantity measurements method
    /// </summary>
    public class QuantityMeasurements
    {
        /// <summary>
        /// Unit conversion object created
        /// </summary>
        private UnitConversion unitConversion = new UnitConversion();

        /// <summary>
        /// To get the converted value
        /// </summary>
        /// <param name="givenValue">given value</param>
        /// <returns>converted value</returns>
        public double GetConvertedValue(double givenValue, UnitConversion.Units unit)
        {
            return givenValue * this.unitConversion.GetConversionUnit(unit);
        }
        
        public override bool Equals(object obj)
        {

            if (obj == null || object.ReferenceEquals(obj, this) || obj.Equals(this.GetType()))
            {
                return true;
            }
            return false;
        }
    }
}
