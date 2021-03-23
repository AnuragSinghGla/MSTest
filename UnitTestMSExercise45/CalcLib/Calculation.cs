using System;

namespace CalcLib
{
    internal class Calculation
    {
        internal double Square(double num1)
        {
            double res = 0;
            try
            {
                res = num1 * num1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of program");
            }

            return res;
        }

        internal double SquareRoot(double num2)
        {
            double res = 0;
            res = Math.Sqrt(num2);
            return res;

        }

        internal double Cube(double num1)
        {
            double res = 0;
            res = num1 * num1 * num1;
            return res;
        }
    }
}