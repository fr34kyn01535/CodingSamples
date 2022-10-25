using System;
using CodingSamples;

namespace CodingSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            TestQuadraticEquationWithOutResult();
        }

        private static void TestQuadraticEquationWithComplexResult(){
            
            double a = ConsoleHelper.ReadDoubleFromConsole("a");
            double b = ConsoleHelper.ReadDoubleFromConsole("b");
            double c = ConsoleHelper.ReadDoubleFromConsole("c");

            QuadraticEquationSolver equationSolver = new QuadraticEquationSolver();
            QuadraticEquationSolver.QuadraticEquationComplexResult result = equationSolver.CalculateWithComplexResult(a, b, c);

            if(result == null)
                Console.WriteLine($"Kein Ergebniss :(");
            else
                Console.WriteLine($"Das Ergebniss ist: {result.FirstZeroPoint} {result.SecondZeroPoint}");
        }

        private  static void  TestQuadraticEquationWithOutResult(){
            
            double a = ConsoleHelper.ReadDoubleFromConsole("a");
            double b = ConsoleHelper.ReadDoubleFromConsole("b");
            double c = ConsoleHelper.ReadDoubleFromConsole("c");

            QuadraticEquationSolver equationSolver = new QuadraticEquationSolver();
            equationSolver.MultiplyResultsTimes1000 = true;
            double x1;
            double? x2;

            if(equationSolver.TryCalculateWithOutResult(a, b, c, out x1, out x2)){
                Console.WriteLine($"Das Ergebniss ist: {x1}{x2}");
            }else{
                Console.WriteLine($"Kein Ergebniss :(");
            }

        }
     
    }
}
