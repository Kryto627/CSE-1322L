
public class Spanish : Language {

    public override string MakeGuess() {
        return "Adivina un numero";
    }

    public override string TooLow() {
        return "Demasiado bajo";
    }

    public override string TooHigh() {
        return "Demasiado alto";
    }

    public override string Correct() {
        return "Correcto";
    }
}