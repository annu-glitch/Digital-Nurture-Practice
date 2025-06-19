public class RecursiveForecast {
    public double futureValue(double initialValue, double growthRate, int years){
        if (years == 0) {      //base case
            return initialValue;
        }
        return (1+growthRate) * futureValue(initialValue, growthRate, years-1);
    }
}
