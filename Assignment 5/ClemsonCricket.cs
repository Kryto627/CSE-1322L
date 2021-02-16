
public class ClemsonCricket : Cricket {

    //Retrieves the chirp count from the environment's temperature.
    public override int GetChirpCount(Environment environment) {
        return (int) (base.GetChirpCount(environment) * 0.8);
    }
}