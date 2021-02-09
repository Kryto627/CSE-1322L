
public abstract class Item {

    //The item's title.
    private string title;

    public Item() {
    SetTitle(string.Empty);
    }

    public Item(string title) {
    SetTitle(title);
    }

    public abstract string GetListing();

    //Retrieves the item's title.
    public string GetTitle() {
    return title;
    }

    //Sets the item's title.
    public void SetTitle(string title) {
    this.title = title;
    }

    public override string ToString() {
    return GetTitle();
    }
}