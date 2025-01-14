using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        // Define a constant MAX_SIZE with a value of 100
        const int max_size = 100;

        // Prompt the user to enter a text
        Console.WriteLine("Enter a text please: ");
        string user_text = Console.ReadLine();

        // Check if the user input is empty or null
        if (string.IsNullOrEmpty(user_text))
        {
            Console.WriteLine("Input is empty!");
            return; // Exit if input is empty
        }

        // Use StringBuilder to create the original and reversed text
        StringBuilder originalSb = new StringBuilder(user_text);
        StringBuilder reversedSb = new StringBuilder();

        // Reverse the text using a loop
        for (int i = originalSb.Length - 1; i >= 0; i--)
        {
            reversedSb.Append(originalSb[i]);
        }

        // Output the original and reversed text
        Console.WriteLine("Original text: " + originalSb.ToString());
        Console.WriteLine("Reversed text: " + reversedSb.ToString());

        // Count the number of vowels in the text
        int count = 0;
        string vowels = "AEIOU";
        foreach (char c in user_text.ToUpper())
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }
        Console.WriteLine($"Number of vowels in the text: {count}");

        // Replace all digits in the text with '*' using StringBuilder
        StringBuilder new_str = new StringBuilder(user_text);
        string numbers = "1234567890";
        foreach (char c in user_text)
        {
            if (numbers.Contains(c))
            {
                new_str.Replace(c, '*');
            }
        }
        Console.WriteLine($"Text without numbers: {new_str}");

        // Print all words that start with an uppercase letter
        string[] input_arr = user_text.Split();
        foreach (string word in input_arr)
        {
            foreach (char c in word)
            {
                if (char.IsUpper(c) && c == word[0])
                {
                    Console.WriteLine($"Word starting with an uppercase letter: {word}");
                }
            }
        }

        // Shorten the text if it exceeds MAX_SIZE and add "..."
        if (user_text.Length > max_size)
        {
            user_text = user_text.Substring(0, max_size) + "...";
        }
        Console.WriteLine($"Shortened text: {user_text}");

        // Find and print the longest word in the text
        string longest_word = "";
        foreach (string word in input_arr)
        {
            if (word.Length > longest_word.Length)
            {
                longest_word = word;
            }
        }
        Console.WriteLine($"Longest word in the text: {longest_word}");
    }
}
