
public class CurrentBooking : Ticket {

    public CurrentBooking() : base() { }

    //Retrieves the price of the ticket.
    public override int GetPrice() {
        return 75;
    }
}