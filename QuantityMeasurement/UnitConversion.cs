/////------------------------------------------------------------------------
////<copyright file="UnitConversion.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------
namespace QuantityMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Unit conversion class
    /// </summary>
    public class UnitConversion
    {

        public enum Units
        {
            INCH_TO_FEET,
            FEET_TO_INCH,
        }

        public double GetConversionUnit(Units unit)
        {
            switch (unit)
            {
                case Units.INCH_TO_FEET:
                    return 1 / 12d;
                case Units.FEET_TO_INCH:
                    return 1 * 12;
                default:
                    return 0;
            }
        }
    }
}
