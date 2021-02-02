
public class MidsizeCar : Vehicle {

    //The daily rental rate.
    private int dailyRentalRate;

    //Vehicle constructor.
    public MidsizeCar(string make, string model, string color, int currentMileage, int originalCost, bool rented, int dailyRentalRate) : base(make, model, color, currentMileage, originalCost, rented) {
        this.dailyRentalRate = dailyRentalRate;
    }

    public override string ToString() {
        return $"Midsized Car: {base.ToString()}";
    }
}