namespace lb1.InfiniteSeries;

public class InfiniteSeries
{
    public static double CalculateSum(Func<int, double> callback, double accuracy)
    {
        double init = callback(0);
        double sum = init;
        double term = init;

        for (int i = 1; Math.Abs(term) >= accuracy; i++)
        {
            term = callback(i);
            sum += term;
        }

        return sum;
    }
}