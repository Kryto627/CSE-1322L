
public class AdvanceBooking : Ticket {

    //The number of days until the game.
    private readonly int numDaysUntilGame;

    public AdvanceBooking(int numDaysUntilGame) : base() {
        this.numDaysUntilGame = numDaysUntilGame;
    }

    //Retrieves the price of the ticket.
    public override int GetPrice() {
        return numDaysUntilGame >= 15 ? 25 : 50;
    }

    //Retrieves the number of days until game.
    public int GetNumberOfDaysUntilGame() {
        return numDaysUntilGame;
    }

    public override string ToString() {
        return base.ToString() + $" for a game in {numDaysUntilGame} days.";
    }
}