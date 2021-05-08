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
    }
}