
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
}