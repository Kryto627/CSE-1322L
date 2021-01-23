using System;

public static class Driver {

    //Starting point of program.
    public static void Main() {

        //Display circles.
        Console.WriteLine("Testing Circles:");
        for (int i = 1; i <= 10; i++) {
            Circle circle = new Circle(i);
            Console.WriteLine($"Area of a circle with radius {i} is {circle.Area()} circumference is {circle.Circumference()}");
        }
        Console.WriteLine();

        //Display rectangles.
        Console.WriteLine("Testing Rectangles:");
        for (int width = 1; width <= 3; width++) {
            for (int height = 1; height <= 3; height++) {
                Rectangle rectangle = new Rectangle(width, height);
                Console.WriteLine($"Area of a rectangle {width} by {height} is {rectangle.Area()} it's perimeter is {rectangle.Perimeter()}");
            }
        }
        Console.WriteLine();

        //Display triangles.
        Console.WriteLine("Testing Triangles:");
        Triangle tri1 = new Triangle(18, 30, 24);
        Console.WriteLine($"Area of a triangle 18x30x24 is {tri1.Area()} it's perimeter is {tri1.Perimeter()} and it's height is {tri1.Height()}");

        Triangle tri2 = new Triangle();
        Console.WriteLine($"Area of a triangle 3x4x5 is {tri2.Area()} it's perimeter is {tri2.Perimeter()} and it's height is {tri2.Height()}");
    }
}
