/////------------------------------------------------------------------------
////<copyright file="QuantityMeasureTest.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------
namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurement;
    using System;

    /// <summary>
    /// Quantity Measure Test
    /// </summary>
    public class QuantityMeasureTest
    {
        /// <summary>
        /// Quantity Measurement
        /// </summary>
        private QuantityMeasurements quantityMeasurements;

        /// <summary>
        /// create object
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.quantityMeasurements = new QuantityMeasurements();
        }

        /// <summary>
        /// If Both The Inputs Are Same Returned Values Are Same And This Case Is Are Equal
        /// </summary>
        [Test]
        public void GivenSameFeetValues_WhenCompared_ShouldReturnEqual()
        {
            double[] feetOne = { 10 }, feetTwo = { 10 };
            double resultOne = this.quantityMeasurements.GetConvertedValue(feetOne, UnitConversion.Units.FEET_TO_INCH);
            double resultTwo = this.quantityMeasurements.GetConvertedValue(feetTwo, UnitConversion.Units.FEET_TO_INCH);
            Assert.AreEqual(resultOne, resultTwo);
        }

        /// <summary>
        /// If Both The Inputs Are Different Returned Values Are Different And This Case Is Are Not Equal
        /// </summary>
        [Test]
        public void GivenSameFeetValues_WhenCompared_ShouldReturnNotEqual()
        {
            double[] feetOne = { 10 }, feetTwo = { 12 };
            double resultOne = this.quantityMeasurements.GetConvertedValue(feetOne, UnitConversion.Units.FEET_TO_INCH);
            double resultTwo = this.quantityMeasurements.GetConvertedValue(feetTwo, UnitConversion.Units.FEET_TO_INCH);
            Assert.AreNotEqual(resultOne, resultTwo);
        }

        [Test]
        public void GivenSameFeetValues_AreZero_WhenCompared_ShouldReturnEqual()
        {
            double[] feetOne = { 0 }, feetTwo = { 0 };
            double resultOne = this.quantityMeasurements.GetConvertedValue(feetOne, UnitConversion.Units.FEET_TO_INCH);
            double resultTwo = this.quantityMeasurements.GetConvertedValue(feetTwo, UnitConversion.Units.FEET_TO_INCH);
            Assert.AreEqual(resultOne, resultTwo);
        }

        [Test]
        public void GiveNullFeetValue_ShouldReturnTrue()
        {
            bool result = this.quantityMeasurements.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void GiveClassReference_ShouldReturnTrue()
        {
            bool result = this.quantityMeasurements.Equals(this.quantityMeasurements);
            Assert.IsTrue(result);
        }

        [Test]
        public void GiveClassReference_TypeChecked_ShouldReturnTrue()
        {
            QuantityMeasurements quantityTypeOne = new QuantityMeasurements();
            QuantityMeasurements quantityTypeTwo = new QuantityMeasurements();
            Assert.AreEqual(quantityTypeOne, quantityTypeTwo);
        }
        [Test]
        public void GivenFeetValue_WhenConvertedToYard_ShouldReturnNotEqual()
        {
            double[] feet = { 3 };
            double yard = quantityMeasurements.GetConvertedValue(feet, UnitConversion.Units.FEET_TO_YARD);
            Assert.AreEqual(1.0, Math.Round(yard));
        }
        [Test]
        public void GivenOneFeetValue_WhenConvertedToYard_ShouldReturnNotEqual()
        {
            double[] feet = { 1 };
            double yard = quantityMeasurements.GetConvertedValue(feet, UnitConversion.Units.FEET_TO_YARD);
            Assert.AreNotEqual(1.0, Math.Round(yard));
        }
        [Test]
        public void GivenOneInchValue_WhenConvertedToYard_ShouldReturnNotEqual()
        {
            double[] inch = { 1.0 };
            double yard = quantityMeasurements.GetConvertedValue(inch, UnitConversion.Units.INCH_TO_YARD);
            Assert.AreNotEqual(1.0, Math.Round(yard));
        }
        [Test]
        public void GivenOneYardValue_WhenConvertedToInch_ShouldReturnEqual()
        {
            double[] yard = { 1.0 };
            double inch = quantityMeasurements.GetConvertedValue(yard, UnitConversion.Units.YARD_TO_INCH);
            Assert.AreEqual(36.0, inch);
        }
        [Test]
        public void GivenThirtySixInchValue_WhenConvertedToYard_ShouldReturnEqual()
        {
            double[] inch = { 36.0 };
            double yard = quantityMeasurements.GetConvertedValue(inch, UnitConversion.Units.INCH_TO_YARD);
            Assert.AreEqual(1, yard);
        }
        [Test]
        public void GivenOneYardValue_WhenConvertedToFeet_ShouldReturnEqual()
        {
            double[] yard = { 1.0 };
            double feet = quantityMeasurements.GetConvertedValue(yard, UnitConversion.Units.YARD_TO_FEET);
            Assert.AreEqual(3, feet);
        }
        [Test]
        public void GivenTwoInchValue_WhenConvertedToCentimeter_ShouldReturnEqual()
        {
            double[] inch = { 2.0 };
            double centimeter = quantityMeasurements.GetConvertedValue(inch, UnitConversion.Units.INCH_TO_CENTIMETER);
            Assert.AreEqual(5, centimeter);
        }
        [Test]
        public void GivenTwoInchValues_WhenAdded_ShouldReturnProperValue()
        {
            double[] inchValues = { 2.0, 2.0 };
            double inch = this.quantityMeasurements.GetConvertedValue(inchValues, UnitConversion.Units.INCH_TO_INCH, UnitConversion.Units.INCH_TO_INCH);
            Assert.AreEqual(4.0, inch);
        }
        [Test]
        public void GivenOneFeetAndOneInchValue_WhenAdded_ShouldReturnProperValue()
        {
            double[] inchValues = { 1.0, 2.0 };
            double inch = this.quantityMeasurements.GetConvertedValue(inchValues, UnitConversion.Units.FEET_TO_INCH, UnitConversion.Units.INCH_TO_INCH);
            Assert.AreEqual(14.0, inch);
        }
        [Test]
        public void GivenTwoFeetValues_WhenAdded_ShouldReturnProperValue()
        {
            double[] inchValues = { 1.0, 1.0 };
            double inch = this.quantityMeasurements.GetConvertedValue(inchValues, UnitConversion.Units.FEET_TO_INCH, UnitConversion.Units.FEET_TO_INCH);
            Assert.AreEqual(24.0, inch);
        }
        [Test]
        public void GivenOneInchAndOneCentimeterValue_WhenAdded_ShouldReturnProperValue()
        {
            double[] inchValues = { 2.0, 2.5 };
            double inch = this.quantityMeasurements.GetConvertedValue(inchValues, UnitConversion.Units.INCH_TO_INCH, UnitConversion.Units.CENTIMETER_TO_INCH);
            Assert.AreEqual(3.0, inch);
        }
        [Test]
        public void GivenOneGallonValue_WhenConverted_ShouldReturnEqual()
        {
            double[] gallon = { 1.0 };
            double litre = this.quantityMeasurements.GetConvertedValue(gallon, UnitConversion.Units.GALLON_TO_LITRE);
            Assert.AreEqual(3.78, litre);
        }
        [Test]
        public void GivenOneLitreValue_WhenConverted_ShouldReturnEqual()
        {
            double[] litre = { 1.0 };
            double ml = this.quantityMeasurements.GetConvertedValue(litre, UnitConversion.Units.LITRE_TO_ML);
            Assert.AreEqual(1000, ml);
        }
        [Test]
        public void GivenOneGallonAndOneLitreValue_WhenConverted_ShouldReturnEqual()
        {
            double[] givenValues = { 1.0, 3.78 };
            double litre = this.quantityMeasurements.GetConvertedValue(givenValues, UnitConversion.Units.GALLON_TO_LITRE, UnitConversion.Units.SAME_UNIT);
            Assert.AreEqual(7.56, litre);
        }
        [Test]
        public void GivenOneLitreAndOneMLValue_WhenConverted_ShouldReturnEqual()
        {
            double[] givenValues = { 1.0, 1000 };
            double litre = this.quantityMeasurements.GetConvertedValue(givenValues, UnitConversion.Units.SAME_UNIT, UnitConversion.Units.ML_TO_LITRE);
            Assert.AreEqual(2, litre);
        }
        [Test]
        public void GivenKGValue_WhenConverted_ToGrams_ShouldReturnEqual()
        {
            double[] kilogram = { 1.0 };
            double grams = this.quantityMeasurements.GetConvertedValue(kilogram, UnitConversion.Units.KG_TO_GRAMS);
            Assert.AreEqual(1000, grams);
        }
        [Test]
        public void GivenTonneValue_WhenConverted_ToKg_ShouldReturnEqual()
        {
            double[] tonne = { 1.0 };
            double kilogram = this.quantityMeasurements.GetConvertedValue(tonne, UnitConversion.Units.TONNE_TO_KG);
            Assert.AreEqual(1000, kilogram);
        }
        [Test]
        public void AddTonneValueAndGrams_WhenAdded_ShouldReturnEqual()
        {
            double[] givenValues = { 1.0, 1000.0 };
            double kilogram = this.quantityMeasurements.GetConvertedValue(givenValues, UnitConversion.Units.TONNE_TO_KG, UnitConversion.Units.GRAMS_TO_KG);
            Assert.AreEqual(1001, kilogram);
        }
    }
}