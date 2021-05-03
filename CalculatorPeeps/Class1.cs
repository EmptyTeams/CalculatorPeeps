using System;

namespace CalculatorPeeps
{
  public static class Calculator 
  {
    //Add-Subtract

    static int addition(int x, int y)
        {
            return x + y;
        }
    static int subtraction(int x, int y)
        {
            return x - y;
        }

        // Multiply-Divide
        static int MaxValue = 2147483647;
        static int Multiply(int one, int two)
        {
            if (!((Double)(one * two) == MaxValue
                && 
                !((Double)(one * two) == -MaxValue)))
            { return one * two; }

            return 0;
        }

        static int Divide(int Numerator, int Divisor)
        {
            if (Divisor == 0)
            { throw new DivideByZeroException("Divisor is 0"); }

            return Numerator / Divisor;
        }
    }
}
