
public class Account {
    
    //Keeps track of the next account number.
    private static int nextNumber = 10001;

    //The account's number.
    private readonly int number;

    //The account's balance.
    private double balance;

    //Default constructor.
    public Account() {
        balance = 0;
        number = nextNumber++;
    }

    //Balance constructor.
    public Account(double balance) : this() {
        this.balance = balance;
    }

    //Withdraws amount from balance.
    public virtual void Withdraw(double amount) {
        SetBalance(GetBalance() - amount);
    }

    //Deposits amount to balance.
    public virtual void Deposit(double amount) {
        SetBalance(GetBalance() + amount);
    }

    //Retrieves the account's number.
    public int GetNumber() {
        return number;
    }

    //Retrieves the account's balance.
    public double GetBalance() {
        return balance;
    }

    //Sets the account's balance.
    public void SetBalance(double balance) {
        this.balance = balance;
    }
}