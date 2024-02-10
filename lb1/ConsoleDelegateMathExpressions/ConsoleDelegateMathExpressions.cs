namespace lb1.ConsoleDelegateMathExpressions;

public class ConsoleDelegateMathExpressions
{
    public static void Start()
    {
        Func<double, double>[] actions =
        {
            (n) => Math.Sqrt(Math.Abs(n)),
            (n) => Math.Pow(n, 3),
            (n) => n + 3.5,
        };

        Console.WriteLine("0 --- sqrt(abs(x))\n1 --- x^3\n2 --- x + 3,5");
        
        while (true)
        {
            try
            {
                string[] input = Console.ReadLine().Split();
                int actionIdx = int.Parse(input[0]);
                double n = double.Parse(input[1]);
                var action = actions[actionIdx];
                
                Console.WriteLine(action(n));
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error occured: {e.Message}");
                break;
            }
        }
    }
}