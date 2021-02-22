using System;

public static class Driver {

    //Starting point of the program.
    public static void Main() {

        Calculator calculator = new Calculator();

        //Loop until the user quits.
        while (true) {

            //Displays options.
            Console.WriteLine();
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine();

            //Prompts the user for option number.
            int option = ReadInt("Please Choose an Option: ");

            if (option == 0) {
                return;
            }

            //Prompts the user for first number.
            float a = ReadFloat("Please enter the first number: ");

            //Prompts the user for second number.
            float b = ReadFloat("Please enter the second number: ");

            switch (option) {
                case 1:
                    Console.WriteLine(calculator.Add(a, b));
                    break;
                case 2:
                    Console.WriteLine(calculator.Subtract(a, b));
                    break;
                case 3:
                    Console.WriteLine(calculator.Multiply(a, b));
                    break;
                case 4:
                    Console.WriteLine(calculator.Divide(a, b));
                    break;
                default:
                    break;
            }
        }
    }

    //Prompts user to enter a integer number.
    private static int ReadInt(string message) {

        //Displays prompt to enter a floating point number.
        Console.Write(message);

        //Reads user input as string.
        string input = Console.ReadLine();

        //Repeats if the string entered is invalid.
        if (int.TryParse(input, out int result)) {
            return result;
        } else {
            return ReadInt(message);
        }
    }

    //Prompts user to enter a floating point number.
    private static float ReadFloat(string message) {

        //Displays prompt to enter a floating point number.
        Console.Write(message);

        //Reads user input as string.
        string input = Console.ReadLine();

        //Repeats if the string entered is invalid.
        if (float.TryParse(input, out float result)) {
            return result;
        } else {
            return ReadFloat(message);
        }
    }
}