
using System.Text;

public class Vehicle {

    //The vehicle's make.
    private string make;

    //The vehicle's model.
    private string model;

    //The vehicle's color.
    private string color;

    //The vehicle's current mileage.
    private int currentMileage;

    //The vehicle's original cost.
    private int originalCost;

    //Is the vehicle currently rented.
    private bool rented;

    //Vehicle constructor.
    public Vehicle(string make, string model, string color, int currentMileage, int originalCost, bool rented) {
        this.make = make;
        this.model = model;
        this.color = color;
        this.currentMileage = currentMileage;
        this.originalCost = originalCost;
        this.rented = rented;
    }

    //Retrieves the make.
    public string GetMake() {
        return make;
    }

    //Sets the make.
    public void SetMake(string make) {
        this.make = make;
    }

    //Retrieves the model.
    public string GetModel() {
        return model;
    }

    //Sets the model.
    public void SetModel(string model) {
        this.model = model;
    }

    //Retrieves the color.
    public string GetColor() {
        return color;
    }

    //Sets the color.
    public void SetColor(string color) {
        this.color = color;
    }

    //Retrieves the current mileage.
    public int GetCurrentMileage() {
        return currentMileage;
    }

    //Sets the current mileage.
    public void SetCurrentMileage(int mileage) {
        this.currentMileage = mileage;
    }

    //Retrieve the original cost.
    public int GetOriginalCost() {
        return originalCost;
    }

    //Sets the original cost.
    public void SetOriginalCost(int cost) {
        this.originalCost = cost;
    }

    //Retrieves is the vehicle rented.
    public bool IsRented() {
        return rented;
    }

    //Sets is the vehicle rented.
    public void SetRented(bool rented) {
        this.rented = rented;
    }

    public override string ToString() {
        StringBuilder builder = new StringBuilder();
        builder.Append(!rented ? "Availale" : "Rented");
        builder.Append($": {color} {make} {model} with {currentMileage} miles");
        return builder.ToString();
    }
}