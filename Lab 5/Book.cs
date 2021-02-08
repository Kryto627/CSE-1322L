using System.Text;

public class Book : Item {

    //The book's ISBN number.
    private long ISBN;

    //The book's author.
    private string author;

    public Book() : base() { }

    public Book(string title, string author, long ISBN) : base(title) {
        SetISBN(ISBN);
        SetAuthor(author);
    }

    //Retrieve's the book's listing.
    public override string GetListing() {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Book Name - {GetTitle()}");
        builder.AppendLine($"Author - {GetAuthor()}");
        builder.AppendLine($"ISBN # - {GetISBN()}");
        return builder.ToString();
    }

    //Retrieves the book's ISBN number.
    public long GetISBN() {
        return ISBN;
    }

    //Sets the book's ISBN number.
    public void SetISBN(long ISBN) {
        this.ISBN = ISBN;
    }

    //Retrieves the book's author.
    public string GetAuthor() {
        return author;
    }

    //Sets the book's author.
    public void SetAuthor(string author) {
        this.author = author;
    }
}