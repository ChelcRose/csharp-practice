public class BasicOperators()
{
    public static void Run()
    {
        int fahrenheit = 94;

        //f to c: -32 then (5/9)

        decimal celsius = (fahrenheit - 32m) * 5m/9m;

        Console.WriteLine($"The temperature is {celsius} Celsius.");
    }
}