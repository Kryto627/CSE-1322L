using System;

public static class Driver {

    /// <summary>
    /// The starting point of the program.
    /// </summary>
    public static void Main() {

        //Create the quiz.
        Quiz quiz = new Quiz();

        //Loop until the user quits.
        while (true) {

            //Display all the options.
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a question to the quiz");
            Console.WriteLine("2. Remove a question from the quiz");
            Console.WriteLine("3. Modify a question in the quiz");
            Console.WriteLine("4. Take the quiz");
            Console.WriteLine("5. Quit");

            //Prompt the user to enter a number.
            Console.WriteLine("Choose a option:");
            int option = int.Parse(Console.ReadLine());

            //Preform the user's option.
            switch (option) {
                case 1:
                    quiz.AddQuestion();
                    break;
                case 2:
                    quiz.RemoveQuestion();
                    break;
                case 3:
                    quiz.ModifyQuestion();
                    break;
                case 4:
                    quiz.GiveQuiz();
                    break;
                case 5:
                    return;
                default:
                    break;
            }
        }
    }
}