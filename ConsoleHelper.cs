using System;

namespace CodingSamples
{
    public static class ConsoleHelper {
        public static double ReadDoubleFromConsole(string description){
            Console.WriteLine($"Bitte numerischen Wert für Parameter {description} eingeben:");
            string line = System.Console.ReadLine();
            double result;
            while(!Double.TryParse(line, out result)){
                Console.WriteLine($"Ungültiger Wert, bitte numerischen Wert für Parameter {description} eingeben:");
                line = Console.ReadLine();
            }
            return result;
        }

    }


}