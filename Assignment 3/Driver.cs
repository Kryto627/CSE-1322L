using System;
using System.Collections.Generic;

public static class Driver {

    //The starting point of the program.
    public static void Main() {

        //Create list for vehicles.
        List<Vehicle> vehicles = new List<Vehicle>();

        //Registers vehicles.
        vehicles.Add(new EconomyCar("Nissan", "Versa", "Blue", 105, 14500, false, 25));
        vehicles.Add(new EconomyCar("Toyota", "Yaris", "White", 8422, 17500, false, 25));
        vehicles.Add(new MidsizeCar("Dodge", "Avenger", "Green", 15720, 15000, false, 45));
        vehicles.Add(new MidsizeCar("Ford", "Focus", "Yellow", 2368, 14500, false, 45));
        vehicles.Add(new SUV("Toyota", "Rav4", "Silver", 432, 26150, false, 80));

        //Loop until user quits.
        while (true) {

            //Display main menu.
            Console.WriteLine("1. Rent cars");
            Console.WriteLine("2. Return cars");
            Console.WriteLine("3. Quit");

            //Prompt user for option.
            int option = int.Parse(Console.ReadLine());

            //Select action based on option.
            if (option == 1) {
                RentCars(vehicles);
            } else if (option == 2) {
                ReturnCars(vehicles);
            } else if (option == 3) {
                return;
            }
        }
    }

    //Enter the rent vehicle menu.
    private static void RentCars(List<Vehicle> vehicles) {

        //Loop until user quits.
        while (true) {

            //Display vehicle information.
            Console.WriteLine("Choose a car to rent:");
            ShowCars(vehicles);

            //Prompt user for option.
            int option = int.Parse(Console.ReadLine());

            //Rent vehicle selected or quit.
            if (option != 0) {
                vehicles[option - 1].SetRented(true);
            } else {
                return;
            }
        }
    }

    //Enter the return vehicle menu.
    private static void ReturnCars(List<Vehicle> vehicles) {

        //Loop until user quits.
        while (true) {

            //Display vehicle information.
            Console.WriteLine("Choose a car to return:");
            ShowCars(vehicles);

            //Prompt user for option.
            int option = int.Parse(Console.ReadLine());

            //Return vehicle selected or quit.
            if (option != 0) {
                vehicles[option - 1].SetRented(false);
            } else {
                return;
            }
        }
    }

    //Show all information about the listed vehicles.
    private static void ShowCars(List<Vehicle> vehicles) {

        //Loop through all vehicles.
        for (int i = 0; i <= vehicles.Count; i++) {

            //Display menu item's information.
            if (i == 0) {
                Console.WriteLine($"{i}. Return");
            } else {
                Console.WriteLine($"{i}. {vehicles[i - 1]}");
            }
        }
    }
}