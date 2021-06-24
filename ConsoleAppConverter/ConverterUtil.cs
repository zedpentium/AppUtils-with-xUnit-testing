using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppConverter
{
    public class ConverterUtil
    {
        //----------------------------------- Temperature Converters ------------------------------------------------------------------------
        /*
            Absolute Zero	    -459.67°F	-273.15°C
            Parity	            -40°F	    -40°C
            Zero	            0°F	        -17.78°C
            Freezing point	    32°F	    0°C
            Body Temperature	98.6°F	    37°C
            Boiling point	    212°F	    100°C
        */
        public static double CelsiusToFahrenheit(double celsius)
        {
            double celsiusToFahrenheit = (celsius * 1.8) + 32;
            return celsiusToFahrenheit;
            //To convert temperatures in degrees Celsius to Fahrenheit, multiply by 1.8 and add 32.
            //throw new NotImplementedException();
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double fahrenheitToCelsius = (fahrenheit - 32 ) / 1.8;
            return fahrenheitToCelsius;
            //To convert temperatures in degrees Fahrenheit to Celsius, subtract 32 and multiply by 0.5556.
            //throw new NotImplementedException();
        }

        //---------------------------------------------------------------------------------------------------------------------------------

        //----------------------------------- Distances Converters ------------------------------------------------------------------------
        /*
            Miles       Kilometers
            10          16,0934
            25          40,2336
            50          80,4672
            6,2137      10
            15,5343     25
            31,0686     50
        */
        public static double KilometersToMiles(double kilometers)
        {
            double kmToMile = kilometers * 0.62137;
            return kmToMile;
            //1Km is equivalent to 0.62137 miles.
            //throw new NotImplementedException();
        }

        public static double MilesToKilometers(double miles)
        {
            double mileToKm = miles * 1.60934;
            return mileToKm;
            //1 miles is equivalent to 1.60934Km.
            //throw new NotImplementedException();
        }

        //---------------------------------------------------------------------------------------------------------------------------------

        //----------------------------------- Length Converters ------------------------------------------------------------------------
        /*
            Centimeters     Inches
            10              3,93701
            25              9,84252
            50              19,68504
            25,4            10
            63,5            25
            127             50

        */
        public static double CentimetersToInches(double centimeters)
        {
            double cmToInch = centimeters * 0.3937;
            return cmToInch;
            //1cm is equivalent to 0.3937 inches.
            //throw new NotImplementedException();
        }

        public static double InchesToCentimeters(double inches)
        {
            double inchToCm = inches * 2.54;
            return inchToCm;
            //1 inches is equivalent to 2.54 cm.
            //throw new NotImplementedException();
        }

        //---------------------------------------------------------------------------------------------------------------------------------

    }
}
