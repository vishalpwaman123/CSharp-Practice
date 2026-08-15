namespace C__Practice
{
    public class Example11
    {
        public static void Run()
        {

            //Q11. Group words that are anagrams

            string[] texts = ["eat", "tea", "tan", "ate", "nat", "bat"];
            Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

            foreach (string text in texts)
            {
                char[] chars = text.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);

                if (!groups.ContainsKey(key)) {
                    groups[key] = new List<string>();
                }

                groups[key].Add(text);
            }

            foreach(var group in groups)
            {
                Console.WriteLine(string.Join(", ", group.Value));
            }
        }
    }
}
