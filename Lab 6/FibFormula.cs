using System;

public class FibFormula : FindFib {

    //Implements the formula version of Fibonacci.
    public int CalculateFib(int i) {

        double j = Math.Sqrt(5);
        double k = Math.Pow((1 + j) / 2, i);
        double l = Math.Pow((1 - j) / 2, i);

        return (int)((k - l) / j);
    }
}