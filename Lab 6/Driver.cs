using System;

public static class Driver {

    //Starting point of the program.
    public static void Main() {

        //Loop util user quits program.
        while (true) {

            //Prompt user to enter a number.
            Console.WriteLine("Enter the number you want to find the Fibonacci Series for:");

            //Read user input as string.
            string input = Console.ReadLine();

            //Convert input string into a number, skip if the string is not a number.
            if (!int.TryParse(input, out int number)) continue;

            //Preform iteration calcuation.
            FindFib iteration = new FibIteration();
            int iterationOutput = iteration.CalculateFib(number);
            Console.WriteLine($"Fib of {number} by iteration is: {iterationOutput}");

            //Preform formula calcuation.
            FindFib formula = new FibFormula();
            int formulaOutput = formula.CalculateFib(number);
            Console.WriteLine($"Fib of {number} by formula is: {formulaOutput}");
        }
    }
}