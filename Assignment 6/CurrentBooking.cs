
public class CurrentBooking : Ticket {

    public CurrentBooking() : base() { }

    //Retrieves the price of the ticket.
    public override int GetPrice() {
        return 75;
    }

    public override string ToString() {
        return base.ToString() + $" for today's game.";
    }
}