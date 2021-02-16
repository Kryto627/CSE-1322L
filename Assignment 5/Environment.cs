
public class Environment {

    //Stores the temperature in Fahrenheit.
    private int temperature;

    //Environment constructor that sets the temperature.
    public Environment(int temperature) {
        this.temperature = temperature;
    }

    //Retrieves the temperature.
    public int GetTemperature() {
        return temperature;
    }

    //Sets the temperature.
    public void SetTemperature(int temperature) {
        this.temperature = temperature;
    }
}