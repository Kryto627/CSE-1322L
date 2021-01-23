using System;

public static class Driver {

    public static void Main() {

        //Create items milk and bread.
        StockItem milk = new StockItem("1 Gallon of Milk", 3.60, 15);
        StockItem bread = new StockItem("1 Loaf of Bread", 1.98, 30);

        //Start system loop.
        while (true) {

            //Prints options to the user.
            Console.WriteLine("1. Sold One Milk");
            Console.WriteLine("2. Sold One Bread");
            Console.WriteLine("3. Change price of Milk");
            Console.WriteLine("4. Change price of Bread");
            Console.WriteLine("5. Add Milk to Inventory");
            Console.WriteLine("6. Add Bread to Inventory");
            Console.WriteLine("7. See Inventory");
            Console.WriteLine("8. Quit");

            //Prompts user for option number.
            int option = int.Parse(Console.ReadLine());

            //Option: Sold One Milk.
            if (option == 1) {
                milk.LowerQuantity(1);
            } 
            
            //Option: Sold One Bread.
            else if (option == 2) {
                bread.LowerQuantity(1);
            } 
            
            //Option: Change price of Milk.
            else if (option == 3) {
                Console.WriteLine("What is the new price for Milk");
                double price = double.Parse(Console.ReadLine());
                milk.SetPrice(price);
            } 
            
            //Option: Change price of Bread.
            else if (option == 4) {
                Console.WriteLine("What is the new price for Bread");
                double price = double.Parse(Console.ReadLine());
                bread.SetPrice(price);
            } 
            
            //Option: Add Milk to Inventory.
            else if (option == 5) {
                Console.WriteLine("How many milk did we get?");
                int quantity = int.Parse(Console.ReadLine());
                milk.RaiseQuantity(quantity);
            } 
            
            //Option: Add Bread to Inventory.
            else if (option == 6) {
                Console.WriteLine("How many bread did we get?");
                int quantity = int.Parse(Console.ReadLine());
                bread.RaiseQuantity(quantity);
            } 
            
            //Option: See Inventory.
            else if (option == 7) {
                Console.WriteLine(milk);
                Console.WriteLine(bread);
            } 
            
            //Option: Quit.
            else if (option == 8) {
                return;
            }
        }
    }
}