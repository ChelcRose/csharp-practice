public class ArrayBasics()
{
    public static void Run()
    {
        string[] fraudulentOrderIDs = {"A123", "B123", "C123"};
        int[] intArr = new int[2];

        Console.WriteLine($"Length of array: {fraudulentOrderIDs.Length}");


        string[] names = {"Rowena", "Ching", "Rhodora"};
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        int[] numbers = {1, 3, 9, 10};
        int sum = 0;

        foreach(int number in numbers)
        {
            sum += number;
            Console.WriteLine(number);
        }
        Console.WriteLine($"The sum of all numbers: {sum}");
    }
}