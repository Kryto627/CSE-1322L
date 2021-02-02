
public class SUV : Vehicle {

    //The daily rental rate.
    private int dailyRentalRate;

    //Vehicle constructor.
    public SUV(string make, string model, string color, int currentMileage, int originalCost, bool rented, int dailyRentalRate) : base(make, model, color, currentMileage, originalCost, rented) {
        this.dailyRentalRate = dailyRentalRate;
    }

    public override string ToString() {
        return $"SUV: {base.ToString()}";
    }
}