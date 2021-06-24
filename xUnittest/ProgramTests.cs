using System;
using Xunit;

namespace ConsoleAppConverter.Tests
{
    public class ConverterUtilTests
    {
        public double[] storeResults = new double[4];

        [Fact]
        public void CelToFahrConvert()
        {
            //Arrange
            double[] valuesToConvert = new double[] { -273.15, -40, 0, 100 };

            //Act
            for (int i = 0; i < 4; i++)
            {
                storeResults[i] = Math.Round(ConverterUtil.CelsiusToFahrenheit(valuesToConvert[i]), 2);
            }
    
        //Assert
            Assert.Equal(-459.67, storeResults[0]);
            Assert.Equal(-40, storeResults[1]);
            Assert.Equal(32, storeResults[2]);
            Assert.Equal(212, storeResults[3]);
        }


        [Fact]
        public void FahrToCelConvert()
        {
            //Arrange
            double[] valuesToConvert = new double[] { -459.67, 98.6, 32, 212 };

            //Act
            for (int i = 0; i < 4; i++)
            {
                storeResults[i] = Math.Round(ConverterUtil.FahrenheitToCelsius(valuesToConvert[i]), 2);
            }

            //Assert
            Assert.Equal(-273.15, storeResults[0]);
            Assert.Equal(37, storeResults[1]);
            Assert.Equal(0, storeResults[2]);
            Assert.Equal(100, storeResults[3]);
        }




        [Fact]
        public void KilometersToMilesConvert()
        {
            //Arrange
            double[] valuesToConvert = new double[] { 16.0934 , 80.4672, 25, 50 };

            //Act
            for (int i = 0; i < 4; i++)
            {
                storeResults[i] = Math.Round(ConverterUtil.KilometersToMiles(valuesToConvert[i]), 2);
            }

            //Assert
            Assert.Equal(10, storeResults[0]);
            Assert.Equal(50, storeResults[1]);
            Assert.Equal(15.53, storeResults[2]);
            Assert.Equal(31.07, storeResults[3]);
        }


        [Fact]
        public void MilesToKilometersConvert()
        {
            //Arrange
            double[] valuesToConvert = new double[] { 2.5, 53, 12.53, 568 };

            //Act
            for (int i = 0; i < 4; i++)
            {
                storeResults[i] = Math.Round(ConverterUtil.MilesToKilometers(valuesToConvert[i]), 2);
            }

            //Assert
            Assert.Equal(4.02, storeResults[0]);
            Assert.Equal(85.30, storeResults[1]);
            Assert.Equal(20.17, storeResults[2]);
            Assert.Equal(914.11, storeResults[3]);
        }




        [Fact]
        public void CentimetersToInchesConvert()
        {
            //Arrange
            double[] valuesToConvert = new double[] { 10, 53, 12.53, 368 };

            //Act
            for (int i = 0; i < 4; i++)
            {
                storeResults[i] = Math.Round(ConverterUtil.CentimetersToInches(valuesToConvert[i]), 2);
            }

            //Assert
            Assert.Equal(3.94, storeResults[0]);
            Assert.Equal(20.87, storeResults[1]);
            Assert.Equal(4.93, storeResults[2]);
            Assert.Equal(144.88, storeResults[3]);
        }


        [Fact]
        public void InchesToCentimetersConvert()
        {
            //Arrange
            double[] valuesToConvert = new double[] { 10, 53, 12.53, 368 };

            //Act
            for (int i = 0; i < 4; i++)
            {
                storeResults[i] = Math.Round(ConverterUtil.InchesToCentimeters(valuesToConvert[i]), 2);
            }

            //Assert
            Assert.Equal(25.40, storeResults[0]);
            Assert.Equal(134.62, storeResults[1]);
            Assert.Equal(31.83, storeResults[2]);
            Assert.Equal(934.72, storeResults[3]);
        }
    }
}
