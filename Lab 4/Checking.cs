using System;

public class Checking : Account {

    //Default constructor.
    public Checking() : base() { }

    //Withdraws and charges overdraft.
    public override void Withdraw(double amount) {
        base.Withdraw(amount);

        if (GetBalance() < 0) {
            Console.WriteLine("Charging an overdraft fee of $20 because account is below $0.");
            SetBalance(GetBalance() - 20);
        }
    }
}