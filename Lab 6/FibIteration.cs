
public class FibIteration : FindFib {

    //Implements the iteration version of Fibonacci
    public int CalculateFib(int i) {
         
        if (i <= 2) return 1;

        int x = 1;
        int y = 1;
        int sum = 0;

        for (int j = 0; j < i - 2; j++) {
            sum = x + y;
            y = x;
            x = sum;
        }

        return sum;
    }
}