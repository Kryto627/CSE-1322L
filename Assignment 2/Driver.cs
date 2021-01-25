using System;

public static class Driver {

    /// <summary>
    /// The starting point of the program.
    /// </summary>
    public static void Main() {

        //Create encryption/decryption helper.
        Caesar caesar = new Caesar();

        //Loop until the user wants to quits.
        while (true) {

            //Display option to user.
            Console.WriteLine("1 Encrypt a message");
            Console.WriteLine("2 Decrypt a message");
            Console.WriteLine("3 Quit");

            //Prompt user to choose a option.
            int option = int.Parse(Console.ReadLine());

            //Preform user option.
            switch (option) {
                case 1:
                    Console.WriteLine("What is the message to encrypt?");
                    Console.WriteLine($"Encrypted: {caesar.Encrypt(Console.ReadLine().ToLower())}");
                    break;
                case 2:
                    Console.WriteLine("What is the encrypted message?");
                    Console.WriteLine($"Encrypted: {caesar.Decrypt(Console.ReadLine().ToLower())}");
                    break;
                case 3:
                    return;
                default:
                    break;
            }
        }
    }
}