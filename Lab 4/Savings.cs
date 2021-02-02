using System;

public class Savings : Account {

    //The account's amount of deposits.
    private int depositCount;

    //Default constructor.
    public Savings() : base() { }

    //Withdraws and charges when below $500.
    public override void Withdraw(double amount) {
        base.Withdraw(amount);

        if (GetBalance() < 500) {
            Console.WriteLine("Charging an fee $10 because you are below $500.");
            SetBalance(GetBalance() - 10);
        }
    }

    //Deposits and charges when depositing over 5 times.
    public override void Deposit(double amount) {
        base.Deposit(amount);

        depositCount++;
        Console.WriteLine($"The is deposit {depositCount} to this account.");

        if (depositCount >= 6) {
            Console.WriteLine("Charging a fee of $10.");
            SetBalance(GetBalance() - 10);
        }
    }

    //Apply and adds interest.
    public void Interest() {
        double interest = GetBalance() * 0.015;
        Console.WriteLine($"Customer earned {interest} in interest.");
        SetBalance(GetBalance() + interest);
    }
}