using System;

public class Triangle {

    /// <summary>
    /// The lengths of the triangle.
    /// </summary>
    private double side1, side2, side3;

    public Triangle() : this(3, 4, 5) { }

    public Triangle(double side1, double side2, double side3) {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public override string ToString() {
        return $"Triangle has {side1}, {side2}, and {side3}. It has an area of {Area()} and perimeter of {Perimeter()}";
    }

    /// <summary>
    /// Retrieves the perimeter of the triangle.
    /// </summary>
    public double Perimeter() {
        return side1 + side2 + side3;
    }

    /// <summary>
    /// Retrieves area of the triangle.
    /// </summary>
    public double Area() {
        double p = (side1 + side2 + side3) / 2;
        return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
    }

    /// <summary>
    /// Retrieves height of the triangle.
    /// </summary>
    public double Height() {
        double min = Math.Min(side1, Math.Min(side2, side3));
        return (Area() * 2) / min;
    }
}