using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo_1
{
    class Program
    {
        //variable
        private const int CELSIUS = 1;
        private const int FAHRENHEIT = 2;
        private const int KELVIN = 3;
        private const int REAMUR = 4;
        

       // private static int input;

        static void Main(string[] args)
        {
//some changes
            Console.WriteLine("Welcome to the Temperature Converter App!\n");
            do
            {
                DiplayMenu();
                // int input1 = Console.Read();
                
                int input1;
                int.TryParse(Console.ReadLine(), out input1);

                if (input1 != 1 && input1 != 2 && input1 != 3 && input1 != 4)
                {
                    Console.WriteLine("\nExiting now!");
                    break;
                }
                    
                Console.WriteLine("Enter the temperature value: ");

                //instead error handling (accept just float numbers)
                float input2 = 0;
                bool conversionOk = float.TryParse(Console.ReadLine(), out input2);
                if (!conversionOk)
                {
                    Console.WriteLine("The entered value is not valid!\n");
                    break;
                }

                float celsius = 0;
                float fahrenheit = 0;
                float kelvin = 0;
                float reamur = 0;

                switch (input1){
                    case CELSIUS:
                        celsius = input2;
                        break;
                    case FAHRENHEIT:
                        celsius = FahrenheitToCelsius(input2);
                        break;
                    case KELVIN:
                        celsius = KelvinToCelsius(input2);
                        break;
                    case REAMUR:
                        celsius = ReamurToCelsius(input2);
                        break;
                }
                fahrenheit = CelsiusToFahrenheit(celsius);
                kelvin = CelsiusToKelvin(celsius);
                reamur = CelsiusToReamur(celsius);

                Results(celsius, fahrenheit, kelvin, reamur);
                Console.WriteLine("Do you want to repeat? (y/n)");
                
                if (Console.ReadKey().KeyChar == 'n')
                {
                    break;
                }
                   
            } while (true);

            Console.WriteLine("\nThanks for using the Temperature Converter App.");
            Console.ReadLine();
        }

        private static void DiplayMenu()
        {
            //Console.WriteLine("SCALE OF TEMPERATURE:\n");
            Console.WriteLine("\nPlease select from which temperature you want to convert\n");
            Console.WriteLine("\t{0}- Celsius\n", CELSIUS);
            Console.WriteLine("\t{0}- Fahrenheit\n", FAHRENHEIT);
            Console.WriteLine("\t{0}- Kelvin\n", KELVIN);
            Console.WriteLine("\t{0}- Reamur\n", REAMUR);
            Console.WriteLine("Select any other number to exit\n");
        }

        private static float CelsiusToFahrenheit(float temp)
        {
            return (temp * 9f/5f) + 32;
        }
        private static float FahrenheitToCelsius(float temp)
        {
            return (temp - 32) * (9f/5f);
        }

        private static float CelsiusToKelvin(float temp)
        {
            return temp + 273.15f;
        }
        private static float KelvinToCelsius(float temp)
        {
            return temp - 273.15f;
        }

        private static float CelsiusToReamur(float temp)
        {
            return temp * 0.8f;
        }
        private static float ReamurToCelsius(float temp)
        {
            return temp * 1.25f;
        }

        private static void Results(float celsius, float fahrenheit, float kelvin, float reamur)
        {
            Console.WriteLine("\nConverted temperatures: \n");
            Console.WriteLine("Celsius: {0}°\nFahrenheit: {1}°\nKelvin: {2}°\nReamur: {3}°\n", celsius, fahrenheit, kelvin, reamur);
        }

    }
}
