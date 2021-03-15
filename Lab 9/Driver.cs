using System;

public static class Driver {

    //The starting point of the program.
    public static void Main() {

        //Loop until user quits.
        while (true) {

            //Display options.
            Console.WriteLine("Choose from the following:");
            Console.WriteLine("0. Quit");
            Console.WriteLine("1. Multiply 2 numbers");
            Console.WriteLine("2. Div 2 numbers");
            Console.WriteLine("3. Mod 2 numbers");

            //Prompt user to enter choice as number.
            int choice = int.Parse(Console.ReadLine());

            //Preform function that user selected.
            if (choice == 0) {
                return;
            } else if (choice == 1) {
                Console.WriteLine("Enter first number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int b = int.Parse(Console.ReadLine());
                int c = RecursiveMultiply(a, b);
                Console.WriteLine($"Answer: {c}");
            } else if (choice == 2) {
                Console.WriteLine("Enter first number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int b = int.Parse(Console.ReadLine());
                int c = RecursiveDiv(a, b);
                Console.WriteLine($"Answer: {c}");
            } else if (choice == 3) {
                Console.WriteLine("Enter first number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int b = int.Parse(Console.ReadLine());
                int c = RecursiveMod(a, b);
                Console.WriteLine($"Answer: {c}");
            }
        }
    }

    //Preforms recursive mod. 
    private static int RecursiveMod(int a, int b) {
        if (b == 0) {
            return -1;
        } else if (b > a) {
            return a;
        } else {
            return RecursiveMod(a - b, b);
        }
    }

    //Preforms recursive div. 
    private static int RecursiveDiv(int a, int b) {
        if (b == 0) {
            return -1;
        } else if (b == 1) {
            return 1;
        } else if (b > a) {
            return 0;
        } else {
            return 1 + RecursiveDiv(a - b, b);
        }
    }

    //Preforms recursive multiply. 
    private static int RecursiveMultiply(int a, int b) {
        if (b == 0) {
            return 0;
        } else {
            return a + RecursiveMultiply(a, b - 1);
        }
    }
}