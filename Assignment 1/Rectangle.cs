
public class Rectangle {

    /// <summary>
    /// The width and height of the rectangle.
    /// </summary>
    private double width, height;

    public Rectangle(double width, double height) {
        this.width = width;
        this.height = height;
    }

    /// <summary>
    /// Retrieves the rectangle's perimeter.
    /// </summary>
    public double Perimeter() {
        return (2 * width) + (2 * height);
    }

    /// <summary>
    /// Retrieves the rectablge's area.
    /// </summary>
    public double Area() {
        return width * height;
    }
}