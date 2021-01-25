
public class Question {

    /// <summary>
    /// The question.
    /// </summary>
    private string text;

    /// <summary>
    /// The question's answer.
    /// </summary>
    private string answer;

    /// <summary>
    /// How hard is the question (1 is easy and 3 is hard).
    /// </summary>
    private int difficulty;

    public Question(string text, string answer, int difficulty) {
        this.text = text;
        this.answer = answer;
        this.difficulty = difficulty;
    }

    /// <summary>
    /// Sets the question.
    /// </summary>
    public void SetText(string text) {
        this.text = text;
    }

    /// <summary>
    /// Sets the question's answer.
    /// </summary>
    public void SetAnswer(string answer) {
        this.answer = answer;
    }

    /// <summary>
    /// Sets the question's difficulty.
    /// </summary>
    public void SetDifficulty(int difficulty) {
        this.difficulty = difficulty;
    }

    /// <summary>
    /// Retrieves the question.
    /// </summary>
    public string GetText() {
        return text;
    }

    /// <summary>
    /// Retrieves the question's answer.
    /// </summary>
    public string GetAnswer() {
        return answer;
    }

    /// <summary>
    /// Retrieves the question's difficulty.
    /// </summary>
    public int GetDifficulty() {
        return difficulty;
    }
}