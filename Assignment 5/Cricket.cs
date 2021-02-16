
public class Cricket {

    //Retrieves the chirp count from the environment's temperature.
    public virtual int GetChirpCount(Environment environment) {
        return (environment.GetTemperature() * 4) - 40;
    }
}