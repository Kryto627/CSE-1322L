
public class SimplifiedChinese : Language {

    public override string MakeGuess() {
        return "猜一个数字";
    }

    public override string TooLow() {
        return "太低";
    }

    public override string TooHigh() {
        return "太高";
    }

    public override string Correct() {
        return "正确";
    }
}