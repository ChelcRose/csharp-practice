public class IterationChallenge()
{
    public static void Run()
    {
        string[] arr = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
        foreach(string newArr in arr)
        {
           if(newArr.StartsWith('B')){
                Console.WriteLine(newArr);
            }
        }
    }
}