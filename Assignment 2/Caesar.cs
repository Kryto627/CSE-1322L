using System.Collections.Generic;

public class Caesar {

    /// <summary>
    /// The unmodifed alphabet.
    /// </summary>
    private readonly List<char> alphabet = new List<char>();

    public Caesar() {
        for (char letter = 'a'; letter <= 'z'; letter++) {
            alphabet.Add(letter);
        }
    }

    /// <summary>
    /// Retrieves the position of the character.
    /// </summary>
    public int PositionOfChar(char letter) {

        //Iterates through all characters in alphabet.
        for (int i = 0; i < alphabet.Count; i++) {

            //Checks if character match.
            if (alphabet[i] == letter) {
                return i;
            }
        }

        return -1;
    }

    /// <summary>
    /// Retrieves the character from a position.
    /// </summary>
    public char LetterAtPosition(int index) {
        return alphabet[index];
    }

    /// <summary>
    /// Encrypts the character.
    /// </summary>
    public char EncryptChar(char letter) {

        //Get position of character.
        int index = PositionOfChar(letter);

        //Increments the position by three.
        index += 3;

        //Prevents array index out of bounds.
        if (index >= 26) index -= 26;

        //Retrieves the character at position.
        return LetterAtPosition(index);
    }

    /// <summary>
    /// Decrypts the character.
    /// </summary>
    public char DecryptChar(char letter) {

        //Get position of character.
        int index = PositionOfChar(letter);

        //Decrements the position by three.
        index -= 3;

        //Prevents array index out of bounds.
        if (index < 0) index += 26;

        //Retrieves the character at position.
        return LetterAtPosition(index);
    }

    /// <summary>
    /// Encrypts the message.
    /// </summary>
    public string Encrypt(string message) {

        //Create string variable.
        string cipher = string.Empty;

        //Iterate through message characters.
        for (int i = 0; i < message.Length; i++) {

            //Encrypt character at position and append to cipher.
            cipher += EncryptChar(message[i]);
        }

        //Return the result.
        return cipher;
    }

    /// <summary>
    /// Decrypts the cipher.
    /// </summary>
    public string Decrypt(string cipher) {

        //Create string variable.
        string message = string.Empty;

        //Iterate through cipher characters.
        for (int i = 0; i < cipher.Length; i++) {

            //Decrypt character at position and append to message.
            message += DecryptChar(cipher[i]);
        }

        //Return the result.
        return message;
    }
}