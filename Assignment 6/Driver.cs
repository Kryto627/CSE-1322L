using System.Collections.Generic;
using System;

public static class Driver {

    //A arraylist of all tickets created.
    private static readonly List<Ticket> tickets = new List<Ticket>();

    //Starting point of the program.
    public static void Main() {

        //Loop until user wants quits.
        while (true) {

            //Display options.
            DisplayOptions();

            //Prompt the user for a integer.
            int option = ReadInt();

            switch (option) {
                case 1:
                    SellFutureTicket();
                    break;
                case 2:
                    SellTodayGame();
                    break;
                case 3:
                    SellDiscountTicket();
                    break;
                case 4:
                    PrintAllTickets();
                    break;
                case 5:
                    return;
                default:
                    break;
            }
        }
    }

    //Display options.
    private static void DisplayOptions() {
        Console.WriteLine("Choose from the following:");
        Console.WriteLine("1. Sell a Ticket for a future game");
        Console.WriteLine("2. Sell a Ticket for today's game");
        Console.WriteLine("3. Sell a Discount Ticket");
        Console.WriteLine("4. Print All Tickets");
        Console.WriteLine("5. Exit");
    }

    //Prompts the user for a integer.
    private static int ReadInt() {

        //Read the user's input as a string.
        string input = Console.ReadLine();

        //Convert and validate the string to a integer.
        if (int.TryParse(input, out int option)) {
            return option;
        } else {
            return ReadInt();
        }
    }

    //Sells a ticket for a future game.
    private static void SellFutureTicket() {

        //Prompt the user to enter the amount of days.
        Console.WriteLine("How many days until the game?");
        int days = ReadInt();

        //Create the ticket.
        AdvanceBooking ticket = new AdvanceBooking(days);
        tickets.Add(ticket);

        //Display the ticket's information.
        Console.WriteLine($"You sold: {ticket}");
        Console.WriteLine();
    }

    //Sells a ticket for today's game.
    private static void SellTodayGame() {

        //Create the ticket.
        CurrentBooking ticket = new CurrentBooking();
        tickets.Add(ticket);

        //Display the ticket's information.
        Console.WriteLine($"You sold: {ticket}");
        Console.WriteLine();
    }

    //Sells a discount ticket.
    private static void SellDiscountTicket() {

        //Prompt the user to enter the amount of days.
        Console.WriteLine("How many days until the game? [0 for today]");
        int days = ReadInt();

        //Create the ticket.
        DiscountBooking ticket = new DiscountBooking(days);
        tickets.Add(ticket);

        //Display the ticket's information.
        Console.WriteLine($"You sold: {ticket}");
        Console.WriteLine();
    }

    //Displays all tickets.
    private static void PrintAllTickets() {

        Console.WriteLine("Here are all the tickets you sold:");

        foreach (Ticket ticket in tickets) {
            Console.WriteLine(ticket);
        }

        Console.WriteLine();
    }
}