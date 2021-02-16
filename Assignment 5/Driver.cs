using System;

public static class Driver {

    //Starting point of the program.
    public static void Main() {

        //Loop until user quits the program.
        while (true) {

            //Prompts the user to enter a numbers.
            Console.WriteLine("What is the current temperature? (Enter -1 to exit)");

            //Retrieves the user entered string.
            string input = Console.ReadLine();

            //Converts the input string into a number.
            if (!int.TryParse(input, out int number)) continue;

            //Shuts the program down if the user entered -1.
            if (number == -1) return;

            //Create a environment with the entered number.
            Environment environment = new Environment(number);

            //Create a normal Cricket.
            Cricket normal = new Cricket();
            int normalChirps = normal.GetChirpCount(environment);
            Console.WriteLine($"Normal cricket: {number} degrees yields {normalChirps} chirps per minute");

            //Create a Clemson Cricket.
            ClemsonCricket clemson = new ClemsonCricket();
            int clemsonChirps = clemson.GetChirpCount(environment);
            Console.WriteLine($"Clemson cricket: {number} degrees yields {clemsonChirps} chirps per minute");
        }
    }
}