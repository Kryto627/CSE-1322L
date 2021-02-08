
public class English : Language {

    public override string MakeGuess() {
        return "Guess a number";
    }

    public override string TooLow() {
        return "Too Low";
    }

    public override string TooHigh() {
        return "Too High";
    }

    public override string Correct() {
        return "Correct";
    }
}