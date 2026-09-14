using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary_Project
{
    public class Url
    {
        private readonly Dictionary<string, string> _url = new();
        private readonly string letters = "qwertyuiopasdfghjklzxcvbnm";
        private readonly string numbers = "1234567890";

        public string Shorten(string url)
        {

            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException("Url cannot be empty");

            string shortCode = string.Empty;
            do
            {
                shortCode = GetShortCode();
            } while (_url.ContainsKey(shortCode));


            _url.Add(shortCode, url);

            return shortCode;
        }

        public string GetOriginalUrl(string shortCode)
        {
            if (string.IsNullOrWhiteSpace(shortCode))
                throw new ArgumentException("Short code cannot empty");

            if (!_url.TryGetValue(shortCode, out string? url))
                throw new InvalidOperationException("Short code not found");

            return url;
        }

        public string GetShortCode()
        {
            string result = string.Empty;

            for (int i = 0; i < 3; i++)
                result += letters[Random.Shared.Next(letters.Length)];

            for (int i = 0; i < 3; i++)
                result += numbers[Random.Shared.Next(numbers.Length)];

            return result;
        }
    }
}


//4.URL Shortener

//Problem Statement

//Build a simple URL shortener.

//When a user provides a long URL, generate a unique short code.

//Example:

//https://example.com/products/mobile/iphone

//could become:

//abc123

//Implement:

//string Shorten(string url)
//string GetOriginalUrl(string shortCode)