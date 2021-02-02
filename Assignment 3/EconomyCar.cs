
public class EconomyCar : Vehicle {

    //The daily rental rate.
    private int dailyRentalRate;

    //Vehicle constructor.
    public EconomyCar(string make, string model, string color, int currentMileage, int originalCost, bool rented, int dailyRentalRate) : base(make, model, color, currentMileage, originalCost, rented) {
        this.dailyRentalRate = dailyRentalRate;
    }

    public override string ToString() {
        return $"Economy Car: {base.ToString()}";
    }
}