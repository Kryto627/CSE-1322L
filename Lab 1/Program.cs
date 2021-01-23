﻿using System;

public static class Program {

    //Starting point of the application.
    public static void Main() {

        //Call and store the original ASCII art.
        char[,] art = make_forward();

        //Draw the original art to screen.
        for (int y = 0; y < 4; y++) {
            for (int x = 0; x < 13; x++) {
                Console.Write(art[y, x]);
            }
            Console.WriteLine();
        }

        //Call and store the mirrored ASCII art.
        char[,] mirrored = make_mirror(make_forward());

        //Draw the mirrored art to screen.
        for (int y = 0; y < 4; y++) {
            for (int x = 0; x < 13; x++) {
                Console.Write(mirrored[y, x]);
            }
            Console.WriteLine();
        }

        //Draw the mirrored and original art to screen.
        for (int y = 0; y < 4; y++) {
            for (int x = 0; x < 13; x++) {
                Console.Write(art[y, x]);
            }
            for (int x = 0; x < 13; x++) {
                Console.Write(mirrored[y, x]);
            }
            Console.WriteLine();
        }
    }

    //This method returns a mirrored of the input array.
    public static char[,] make_mirror(char[,] original) {

        int rows = 4;
        int columns = 13;

        char[,] mirror = new char[rows, columns];

        for (int y = 0; y < rows; y++) {

            for (int x = 0; x < columns; x++) {

                char c = original[y, x];

                if (c == '(') {
                    c = ')';
                } else if (c == ')') {
                    c = '(';
                } else if (c == '/') {
                    c = '\\';
                } else if (c == '\\') {
                    c = '/';
                }

                mirror[y, columns - (x + 1)] = c;
            }
        }

        return mirror;
    }

    //This method returns the ASCII art array.
    public static char[,] make_forward() {
        char[,] pixel = new char[4, 13];
        pixel[0, 0] = ' ';
        pixel[0, 1] = ' ';
        pixel[0, 2] = '_';
        pixel[0, 3] = '_';
        pixel[0, 4] = '_';
        pixel[0, 5] = '_';
        pixel[0, 6] = '_';
        pixel[0, 7] = '_';
        pixel[0, 8] = ' ';
        pixel[0, 9] = ' ';
        pixel[0, 10] = ' ';
        pixel[0, 11] = ' ';
        pixel[0, 12] = ' ';
        pixel[1, 0] = ' ';
        pixel[1, 1] = '/';
        pixel[1, 2] = '|';
        pixel[1, 3] = '_';
        pixel[1, 4] = '|';
        pixel[1, 5] = '|';
        pixel[1, 6] = '_';
        pixel[1, 7] = '\\';
        pixel[1, 8] = '\'';
        pixel[1, 9] = '.';
        pixel[1, 10] = '_';
        pixel[1, 11] = '_';
        pixel[1, 12] = ' ';
        pixel[2, 0] = '(';
        pixel[2, 1] = ' ';
        pixel[2, 2] = ' ';
        pixel[2, 3] = ' ';
        pixel[2, 4] = '_';
        pixel[2, 5] = ' ';
        pixel[2, 6] = ' ';
        pixel[2, 7] = ' ';
        pixel[2, 8] = ' ';
        pixel[2, 9] = '_';
        pixel[2, 10] = ' ';
        pixel[2, 11] = '_';
        pixel[2, 12] = '\\';
        pixel[3, 0] = '=';
        pixel[3, 1] = '\'';
        pixel[3, 2] = '-';
        pixel[3, 3] = '(';
        pixel[3, 4] = '_';
        pixel[3, 5] = ')';
        pixel[3, 6] = '-';
        pixel[3, 7] = '-';
        pixel[3, 8] = '(';
        pixel[3, 9] = '_';
        pixel[3, 10] = ')';
        pixel[3, 11] = '-';
        pixel[3, 12] = '\'';
        return pixel;
    }
}