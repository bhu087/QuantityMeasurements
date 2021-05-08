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
            GALLON_TO_LITRE,
            LITRE_TO_ML,
            ML_TO_LITRE,
            SAME_UNIT,
            KG_TO_GRAMS,
            TONNE_TO_KG,
            GRAMS_TO_KG,
            FAHRENHEIT_TO_CELSIUS,
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
                case Units.GALLON_TO_LITRE:
                    return 3.78d;
                case Units.LITRE_TO_ML:
                    return 1000.0d;
                case Units.ML_TO_LITRE:
                    return 1 / 1000.0d;
                case Units.KG_TO_GRAMS:
                    return 1000;
                case Units.TONNE_TO_KG:
                    return 1000;
                case Units.GRAMS_TO_KG:
                    return 1 / 1000.0d;
                case Units.FAHRENHEIT_TO_CELSIUS:
                    return 100 / 212d;
                default:
                    return 1;
            }
        }
    }
}
