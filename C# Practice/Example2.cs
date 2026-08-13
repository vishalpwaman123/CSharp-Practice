
namespace C__Practice
{
    public class Example2
    {
        public static void Run()
        {
            //Q2. Find the first non-repeating number

            //DICTIONARY

            Dictionary<int, int> frequency = new Dictionary<int, int>();
            int[] numbers = { 4, 5, 1, 2, 1, 4, 5 };

            foreach (var number in numbers)
            {
                if (frequency.ContainsKey(number))
                    frequency[number]++;
                else
                    frequency[number] = 1;

            }

            foreach (var item in frequency)
            {
                if (item.Value == 1)
                {
                    Console.WriteLine($"First dictionary non-repeating number is: {item.Key}");
                    break;
                }
            }

            // HASHSET

            Console.WriteLine("---------------------------------------------------------");

            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicate = new HashSet<int>();

            foreach (var number in numbers)
            {
                if (!seen.Add(number))
                    duplicate.Add(number);
            }

            foreach (var item in numbers)
            {
                if (!duplicate.Contains(item))
                {
                    Console.WriteLine($"First hash non-repeating number is: {item}");
                    break;
                }
            }

        }
    }
}
