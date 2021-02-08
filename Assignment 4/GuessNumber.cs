using System;

public static class GuessNumber {

    //The game's random number generator.
    private readonly static Random RNG = new Random();

    //Starting point of the program.
    public static void Main() {
        PlayGame();
    }

    //Starts the game.
    private static void PlayGame() {

        //Generate the random number.
        int number = RNG.Next(100);

        //Create language variable.
        Language language = null;

        //Display language choices.
        Console.WriteLine("Choose your language");
        Console.WriteLine("1. English");
        Console.WriteLine("2. Español");
        Console.WriteLine("3. Français");
        Console.WriteLine("4. 简体中文");

        //Prompt user to enter a number.
        int choice = int.Parse(Console.ReadLine());

        //Apply user's choice.
        if (choice == 1) language = new English();
        else if (choice == 2) language = new Spanish();
        else if (choice == 3) language = new French();
        else if (choice == 4) language = new SimplifiedChinese();

        //Loop until user enters correct number.
        while (true) {

            //Prompt user to enter a number.
            Console.WriteLine(language.MakeGuess());
            int guess = int.Parse(Console.ReadLine());

            //Evaluate user's guess.
            if (guess > number) {
                Console.WriteLine(language.TooHigh());
            } else if (guess < number) {
                Console.WriteLine(language.TooLow());
            } else {
                Console.WriteLine(language.Correct());
                return;
            }
        }
    }
}