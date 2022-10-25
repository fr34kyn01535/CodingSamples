namespace CodingSamples
{
    public class QuadraticEquationSolver
    {
        public bool MultiplyResultsTimes1000{get;set;} = false;

        public class QuadraticEquationComplexResult{
            public double FirstZeroPoint { get;set; }
            public double? SecondZeroPoint { get;set; }
        }

        public bool TryCalculateWithOutResult(double a, double b, double c, out double firstZero, out double? secondZero)
        {
            QuadraticEquationComplexResult result = CalculateWithComplexResult(a,b,c);

            firstZero = 0;
            secondZero = 0;
            if(result == null) return false;

            firstZero = result.FirstZeroPoint;
            secondZero = result.SecondZeroPoint;
            return true;
        }

        public QuadraticEquationComplexResult CalculateWithComplexResult(double a, double b, double c)
        {
            QuadraticEquationComplexResult result = new QuadraticEquationComplexResult();
            if (a == 0)
            {
                return null;
            }
            else
            {
                double p = b / a;
                double q = c / a;
                double d = Math.Pow(p / 2, 2) - q;
                if (d < 0)
                {
                return null;
                }
                else
                {
                    if (d == 0)
                    {
                        double x = p / 2;
                        result.FirstZeroPoint = x;
                    }
                    else
                    {
                        double x1 = -p / 2 + Math.Sqrt(d);
                        double x2 = -p / 2 - Math.Sqrt(d);
                        
                        result.FirstZeroPoint = x1;
                        result.SecondZeroPoint = x2;
                    }
                }
            }

            if(MultiplyResultsTimes1000){


                double r = result.FirstZeroPoint;

                MultiplyTimes1000(r); //result.fristzeropoint ist bei speicher 5
                Console.WriteLine(r); //2

                MultiplyTimes1000C(result); //speicher addresse 4
                Console.WriteLine(result.FirstZeroPoint); //result.fristzeropoint ist bei speicher 5

                MultiplyTimes1000R(ref r); //speicher addresse 4
                Console.WriteLine(r); //result.fristzeropoint ist bei speicher 5

                result.FirstZeroPoint = MultiplyTimes1000A(result.FirstZeroPoint);

                result.FirstZeroPoint  = r;

                //result.SecondZeroPoint = result.SecondZeroPoint.HasValue ? result.SecondZeroPoint.Value*1000 : null;
            }

            return result;
        }

        private void MultiplyTimes1000(double number){ //number kriegt ne neue speicheraddresse 6 wo der ursprüngliche wert abgelegt wird
            number = number * 1000; //speicheraddresse 6 geändert
        } //speicheradresse 6 wird gelöscht

        private void MultiplyTimes1000C(QuadraticEquationComplexResult result){ //an speicheraddresse 7 wird speicher addresse 4 abgelegt
            result.FirstZeroPoint = result.FirstZeroPoint * 1000;
        }
        private void MultiplyTimes1000R(ref double number){ //an speicheraddresse 8 wird speicher addresse 5 abgelegt
             number = number * 1000;
        }

        private double MultiplyTimes1000A(double number){ //number kriegt ne neue speicheraddresse 9 wo der ursprüngliche wert abgelegt wird
             return number * 1000;
        }
    }
}