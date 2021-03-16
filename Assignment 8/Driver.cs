using System;

public static class Driver {

    //The starting point of the program.
    public static void Main() {

        //Loop 9 times starting from 1.
        for (int i = 1; i < 10; i++) {

            //Display the folds at current index.
            Console.WriteLine($"For {i} folds we get: {Paperfold(i)}");
        }
    }

    //Reverses a string recursively.
    private static string Reverse(string text) {

        if (string.IsNullOrEmpty(text)) {
            return text;
        }

        return Reverse(text.Substring(1)) + text[0];
    }

    //Inverts all 'v' with '^' and all '^' with 'v'.
    private static string Invert(string text) {
        return text.Replace('v', 'a').Replace('^', 'v').Replace('a', '^');
    }

    //Calculates the pattern of folds on paper.
    private static string Paperfold(int folds) {

        if (folds <= 1) {
            return "v";
        }

        return Reverse(Invert(Paperfold(folds - 1))) + "v" + Paperfold(folds - 1);
    }
}