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
            double feetOne = 10, feetTwo = 10;
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
            double feetOne = 10, feetTwo = 12;
            double resultOne = this.quantityMeasurements.GetConvertedValue(feetOne, UnitConversion.Units.FEET_TO_INCH);
            double resultTwo = this.quantityMeasurements.GetConvertedValue(feetTwo, UnitConversion.Units.FEET_TO_INCH);
            Assert.AreNotEqual(resultOne, resultTwo);
        }

        [Test]
        public void GivenSameFeetValues_AreZero_WhenCompared_ShouldReturnEqual()
        {
            double feetOne = 0, feetTwo = 0;
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
            QuantityMeasurements quantityType1 = new QuantityMeasurements();
            QuantityMeasurements quantityType2 = new QuantityMeasurements();
            Assert.AreEqual(quantityType1, quantityType2);
        }
        [Test]
        public void GivenFeetValue_WhenConvertedToYard_ShouldReturnNotEqual()
        {
            double yard = quantityMeasurements.GetConvertedValue(3, UnitConversion.Units.FEET_TO_YARD);
            Assert.AreEqual(1.0, Math.Round(yard));
        }
        [Test]
        public void GivenOneFeetValue_WhenConvertedToYard_ShouldReturnNotEqual()
        {
            double yard = quantityMeasurements.GetConvertedValue(1.0, UnitConversion.Units.FEET_TO_YARD);
            Assert.AreNotEqual(1.0, Math.Round(yard));
        }
        [Test]
        public void GivenOneInchValue_WhenConvertedToYard_ShouldReturnNotEqual()
        {
            double yard = quantityMeasurements.GetConvertedValue(1.0, UnitConversion.Units.INCH_TO_YARD);
            Assert.AreNotEqual(1.0, Math.Round(yard));
        }
        [Test]
        public void GivenOneYardValue_WhenConvertedToInch_ShouldReturnEqual()
        {
            double inch = quantityMeasurements.GetConvertedValue(1.0, UnitConversion.Units.YARD_TO_INCH);
            Assert.AreEqual(36.0, inch);
        }
        [Test]
        public void GivenThirtySixInchValue_WhenConvertedToYard_ShouldReturnEqual()
        {
            double yard = quantityMeasurements.GetConvertedValue(36.0, UnitConversion.Units.INCH_TO_YARD);
            Assert.AreEqual(1, yard);
        }
        [Test]
        public void GivenOneYardValue_WhenConvertedToFeet_ShouldReturnEqual()
        {
            double feet = quantityMeasurements.GetConvertedValue(1.0, UnitConversion.Units.YARD_TO_FEET);
            Assert.AreEqual(3, feet);
        }
        [Test]
        public void GivenTwoInchValue_WhenConvertedToCentimeter_ShouldReturnEqual()
        {
            double centimeter = quantityMeasurements.GetConvertedValue(2.0, UnitConversion.Units.INCH_TO_CENTIMETER);
            Assert.AreEqual(5, centimeter);
        }
    }
}