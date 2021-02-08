
public class French : Language {

    public override string MakeGuess() {
        return "Devinez un nombre";
    }

    public override string TooLow() {
        return "Trop bas";
    }

    public override string TooHigh() {
        return "Trop haut";
    }

    public override string Correct() {
        return "Correct";
    }
}