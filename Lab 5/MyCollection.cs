using System;
using System.Collections.Generic;

public static class MyCollection {

    //the user's collection of items.
    private readonly static List<Item> items = new List<Item>();

    //The starting point of the program.
    public static void Main() {
        CreateItems();
        DisplayAllItems();
    }

    //Prompts the user to create 5 items.
    private static void CreateItems() {

        for (int i = 0; i < 5; i++) {

            //Display choice.
            Console.WriteLine("Please enter B for Book or P for Periodical");

            //Prompt the user to enter a string.
            string input = Console.ReadLine();

            //Perform user's choice
            if (input == "B") {
                CreateBook();
            } else if (input == "P") {
                CreatePeriodical();
            }
        }
    }

    //Prompts user to create a book.
    private static void CreateBook() {

        //Prompt user for book's title.
        Console.WriteLine("Please enter the name of the Book");
        string title = Console.ReadLine();

        //Prompt user for book's author.
        Console.WriteLine("Please enter the author of the Book");
        string author = Console.ReadLine();

        //Prompt user for book's ISBN number.
        Console.WriteLine("Please enter the ISBN of the Book");
        long ISBN = long.Parse(Console.ReadLine());

        //Construct the book and add to items.
        Book book = new Book(title, author, ISBN);
        items.Add(book);
    }

    //Prompts user to create a periodical.
    private static void CreatePeriodical() {

        //Prompt user for periodical's title.
        Console.WriteLine("Please enter the name of Periodical");
        string title = Console.ReadLine();

        //Prompt user for periodical's issue number.
        Console.WriteLine("Please enter the issue number");
        long issue = long.Parse(Console.ReadLine());

        //Construct the book and add to items.
        Periodical periodical = new Periodical(title, issue);
        items.Add(periodical);
    }

    //Displays all items.
    private static void DisplayAllItems() {

        Console.WriteLine();
        Console.WriteLine("Your Items:");

        foreach (Item item in items) {
            Console.WriteLine(item.GetListing());
        }
    }
}