using System;

public class Circle {

    /// <summary>
    /// The radius of the circle.
    /// </summary>
    private double radius;

    public Circle(double radius) {
        this.radius = radius;
    }

    /// <summary>
    /// Retrieves the circle's circumference.
    /// </summary>
    public double Circumference() {
        return 2 * Math.PI * radius;
    }

    /// <summary>
    /// Retrieve the circle's area.
    /// </summary>
    public double Area() {
        return Math.PI * Math.Pow(radius, 2);
    }
}