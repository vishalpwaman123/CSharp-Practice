namespace C__Practice;

public class DictExample1
{
    public static void Run()
    {
        //Q1. Count frequency of each number

        Dictionary<int, int> frequency = new Dictionary<int, int>();
        int[] numbers = { 1, 2, 3, 4, 5, 6, 3, 4, 5, 6, 7, 8 };

        foreach (var number in numbers)
        {
            if (frequency.ContainsKey(number))           
                frequency[number] += 1;
            else
                frequency[number] = 1;
        }

        foreach (var item in frequency)
            Console.WriteLine($"{item.Key} : {item.Value}");

    }
}
