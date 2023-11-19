using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomical_Processing.Tests
{
    [TestClass]
    public class AstronomicalProcessingTests
    {
        private frmMain astronomicalForm;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the form before each test
            astronomicalForm = new frmMain();
        }

        [TestMethod]
        public void TestMeanCalculation_1()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 10, 20, 30, 40, 50 });

            // Act
            astronomicalForm.btnMean_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Mean : 30.00", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestMeanCalculation_2()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 5, 15, 25, 35, 45 });

            // Act
            astronomicalForm.btnMean_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Mean : 25.00", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestMeanCalculation_3()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 2, 4, 6, 8, 10 });

            // Act
            astronomicalForm.btnMean_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Mean : 6.00", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestMeanCalculation_4()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 100, 200, 300, 400, 500 });

            // Act
            astronomicalForm.btnMean_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Mean : 300.00", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestModeCalculation_1()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 10, 20, 30, 30, 40, 50 });

            // Act
            astronomicalForm.btnMode_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Mode : 30.00 | Occurrences: 2", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestModeCalculation_2()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 5, 15, 25, 35, 45, 45, 50 });

            // Act
            astronomicalForm.btnMode_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Mode : 45.00 | Occurrences: 2", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestModeCalculation_3()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 2, 4, 6, 8, 10, 10, 10 });

            // Act
            astronomicalForm.btnMode_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Mode : 10.00 | Occurrences: 3", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestModeCalculation_4()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 100, 200, 300, 400, 500 });

            // Act
            astronomicalForm.btnMode_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Mode : 100.00 | Occurrences: 1", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestMedianCalculation_1()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 10, 20, 30, 40, 50 });

            // Act
            astronomicalForm.btnMedian_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Median : 30.00", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestMedianCalculation_2()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 5, 15, 25, 35, 45 });

            // Act
            astronomicalForm.btnMedian_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Median : 25.00", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestMedianCalculation_3()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 2, 4, 6, 8, 10 });

            // Act
            astronomicalForm.btnMedian_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Median : 6.00", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestMedianCalculation_4()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 100, 200, 300, 400, 500 });

            // Act
            astronomicalForm.btnMedian_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Median : 300.00", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestRangeCalculation_1()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 10, 20, 30, 40, 50 });

            // Act
            astronomicalForm.btnRange_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Range: 40.00", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestRangeCalculation_2()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 5, 15, 25, 35, 45 });

            // Act
            astronomicalForm.btnRange_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Range: 40.00", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestRangeCalculation_3()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 2, 4, 6, 8, 10 });

            // Act
            astronomicalForm.btnRange_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Range: 8.00", astronomicalForm.textBoxCalc.Text);
        }

        [TestMethod]
        public void TestRangeCalculation_4()
        {
            // Arrange
            astronomicalForm.SetTestData(new int[] { 100, 200, 300, 400, 500 });

            // Act
            astronomicalForm.btnRange_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Range: 400.00", astronomicalForm.textBoxCalc.Text);
        }
    }
}
