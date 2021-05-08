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
            FEET_TO_YARD,
            YARD_TO_FEET,
            INCH_TO_YARD,
            YARD_TO_INCH,
            INCH_TO_INCH,
            INCH_TO_CENTIMETER,
            CENTIMETER_TO_INCH,
        }

        public double GetConversionUnit(Units unit)
        {
            switch (unit)
            {
                case Units.INCH_TO_FEET:
                    return 1 / 12d;
                case Units.FEET_TO_INCH:
                    return 12;
                case Units.FEET_TO_YARD:
                    return (1 / 3d);
                case Units.YARD_TO_FEET:
                    return 3;
                case Units.INCH_TO_YARD:
                    return 1 / 36d;
                case Units.YARD_TO_INCH:
                    return 36;
                case Units.INCH_TO_CENTIMETER:
                    return 2.5;
                case Units.CENTIMETER_TO_INCH:
                    return 1 / 2.5d;
                case Units.INCH_TO_INCH:
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
