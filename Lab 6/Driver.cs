using System;

public static class Driver {

    public static void Main() {

        FindFib fib = new FibIteration();

        for (int i = 1; i < 20; i++) {
            Console.WriteLine(fib.CalculateFib(i));
        }
    }
}