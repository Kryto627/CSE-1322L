
public class DiscountBooking : Ticket {

    //The number of days until the game.
    private readonly int numDaysUntilGame;

    public DiscountBooking(int numDaysUntilGame) : base() {
        this.numDaysUntilGame = numDaysUntilGame;
    }

    //Retrieves the price of the ticket.
    public override int GetPrice() {
        return numDaysUntilGame == 0 ? 75 : 10;
    }
}