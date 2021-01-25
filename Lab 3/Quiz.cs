using System;
using System.Collections.Generic;

public class Quiz {

    /// <summary>
    /// The quiz's questions.
    /// </summary>
    private List<Question> questions;

    public Quiz() {
        questions = new List<Question>();
    }

    /// <summary>
    /// Prompts the user to create a question and adds it to the quiz.
    /// </summary>
    public void AddQuestion() {

        //Prompts the user to enter a question.
        Console.WriteLine("What is the question Text?");
        string text = Console.ReadLine();

        //Prompts the user to enter the question's answer.
        Console.WriteLine("What is the answer?");
        string answer = Console.ReadLine();

        //Prompt the user to enter the question's difficulty.
        Console.WriteLine("How Difficult (1-3)?");
        int difficulty = int.Parse(Console.ReadLine());

        //Creates the question object and adds it to the quiz.
        Question question = new Question(text, answer, difficulty);
        questions.Add(question);
    }

    /// <summary>
    /// Prompts the user to remove a selected question from the quiz.
    /// </summary>
    public void RemoveQuestion() {

        //Displays a list of all questions to the user.
        Console.WriteLine("Choose the question to remove?");
        for (int i = 0; i < questions.Count; i++) {
            Console.WriteLine($"{i}. {questions[i].GetText()}");
        }

        //Prompts the user to select a question's index.
        int index = int.Parse(Console.ReadLine());

        //Removes the selected question from the quiz.
        questions.RemoveAt(index);
    }

    /// <summary>
    /// Prompt the user to change a selected question in the quiz.
    /// </summary>
    public void ModifyQuestion() {

        //Displays a list of all questions to the user.
        Console.WriteLine("Choose the question to modify?");
        for (int i = 0; i < questions.Count; i++) {
            Console.WriteLine($"{i}. {questions[i].GetText()}");
        }

        //Prompts the user to select a question's index.
        int index = int.Parse(Console.ReadLine());

        //Grab the selected question from the quiz.
        Question question = questions[index];

        //Prompts the user to enter a question.
        Console.WriteLine("What is the question Text?");
        question.SetText(Console.ReadLine());

        //Prompts the user to enter the question's answer.
        Console.WriteLine("What is the answer?");
        question.SetAnswer(Console.ReadLine());

        //Prompt the user to enter the question's difficulty.
        Console.WriteLine("How Difficult (1-3)?");
        question.SetDifficulty(int.Parse(Console.ReadLine()));
    }

    /// <summary>
    /// Prompts the user all the questions of the quiz and display a score at the end.
    /// </summary>
    public void GiveQuiz() {

        //Create a quiz score variable.
        int correct = 0;

        //Iterate through all the quiz questions.
        for (int i = 0; i < questions.Count; i++) {

            //Display the current question.
            Console.WriteLine(questions[i].GetText());

            //Prompt the user to enter the answer.
            string input = Console.ReadLine();

            //Display if the answer was correct or incorrect.
            if (input == questions[i].GetAnswer()) {
                Console.WriteLine("Correct!");
                correct++;
            } else {
                Console.WriteLine("Incorrect!");
            }
        }

        //Display the user's quiz score.
        Console.WriteLine($"You got {correct} out of {questions.Count}");
    }
}