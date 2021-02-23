
public abstract class Ticket {

    //The next ticket number to be assigned.
    private static int nextTicketNumber = 1;

    //The ticket's current number.
    private readonly int ticketNumber;

    public Ticket() {
        ticketNumber = nextTicketNumber++;
    }

    //Retrieves the price of the ticket.
    public abstract int GetPrice();

    //Retrieves the ticket's number.
    private int GetTicketNumber() {
        return ticketNumber;
    }

    public override string ToString() {
        return $"Ticket number {ticketNumber} with a price of ${GetPrice()}";
    }
}