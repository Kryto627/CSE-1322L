using System.Text;

public class Periodical : Item {

    //The periodical's issue number.
    private long issue;

    public Periodical() : base() { }

    public Periodical(string title, long issue) : base(title) {
        SetIssue(issue);
    }

    //Retrieves the periodical's listing.
    public override string GetListing() {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Periodical Title - {GetTitle()}");
        builder.AppendLine($"Issue # - {GetIssue()}");
        return builder.ToString();
    }

    //Retrieves the periodical's issue number.
    public long GetIssue() {
        return issue;
    }

    //Sets the periodical's issue number.
    public void SetIssue(long issue) {
        this.issue = issue;
    }
}