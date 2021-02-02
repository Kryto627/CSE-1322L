using System;

public static class Driver {

    //Starting point of the program.
    public static void Main() {

        Checking checking = new Checking();
        Savings savings = new Savings();

        //Main loop of program.
        while (true) {

            //Display options.
            Console.WriteLine("1. Withdraw from Checking");
            Console.WriteLine("2. Withdraw from Savings");
            Console.WriteLine("3. Deposit to Checking");
            Console.WriteLine("4. Deposit to Savings");
            Console.WriteLine("5. Balance of Checking");
            Console.WriteLine("6. Balance of Savings");
            Console.WriteLine("7. Award Interest to Savings now");
            Console.WriteLine("8. Quit");

            //Prompt user for option.
            int option = int.Parse(Console.ReadLine());

            //Withdraw from checking.
            if (option == 1) {
                Console.WriteLine("How much would you like to withdraw from Checking?");
                double amount = double.Parse(Console.ReadLine());
                checking.Withdraw(amount);
            }

            //Withdraw from savings.
            if (option == 2) {
                Console.WriteLine("How much would you like to withdraw from Savings?");
                double amount = double.Parse(Console.ReadLine());
                savings.Withdraw(amount);
            }

            //Deposit to Checking
            if (option == 3) {
                Console.WriteLine("How much would you like to deposit into Checking?");
                double amount = double.Parse(Console.ReadLine());
                checking.Deposit(amount);
            }

            //Deposit to Savings
            if (option == 4) {
                Console.WriteLine("How much would you like to deposit into Savings?");
                double amount = double.Parse(Console.ReadLine());
                savings.Deposit(amount);
            }

            //Balance of Checking
            if (option == 5) {
                Console.WriteLine($"Your balance for checking {checking.GetNumber()} is {checking.GetBalance()}");
            }

            //Balance of Savings
            if (option == 6) {
                Console.WriteLine($"Your balance for savings {savings.GetNumber()} is {savings.GetBalance()}");
            }

            //Award interest.
            if (option == 7) {
                savings.Interest();
            }

            //Quit program.
            if (option == 8) return;
        }
    }
}
