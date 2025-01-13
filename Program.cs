using System.Text;

class Program
{
    public static void Main(string[] args)
    {

        const int max_size = 100;
        // Prompt the user for input
        Console.WriteLine("Enter a text please: ");
        string user_text = Console.ReadLine();

        // Check if the user input is empty or null
        if (string.IsNullOrEmpty(user_text))
        {
            Console.WriteLine("Input is empty!");
            return; // Exit if input is empty
        }

        // Create a StringBuilder for the original text (no changes to original input)
        StringBuilder originalSb = new StringBuilder(user_text);
        StringBuilder reversedSb = new StringBuilder();

        // Iterate backward through the original string to append the characters in reverse order
        for (int i = originalSb.Length - 1; i >= 0; i--)
        {
            reversedSb.Append(originalSb[i]);
        }

        // Output the original and reversed text
        Console.WriteLine("Original text: " + originalSb.ToString());
        Console.WriteLine("Reversed text: " + reversedSb.ToString());

        int count = 0;
        string vowels = "AEIOU";
        foreach (char c in user_text.ToUpper())
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        Console.WriteLine($"vowels in user text is: {count}");

        StringBuilder new_str = new StringBuilder(user_text);
        string numbers = "1234567890";
        foreach (char c in user_text)
        {
            if(numbers.Contains(c))
            {
                new_str.Replace(c, '*');
            }
        }

        Console.WriteLine($"New string withour number is: {new_str}");

        string[] input_arr = user_text.Split();
        foreach (string word in input_arr)
        {
            foreach (char c in word)
            {
                if(char.IsUpper(c) && c == word[0])
                {
                    Console.WriteLine($"Word that sturt with upper: {word}");
                }
            }
            
        }
        
       if (user_text.Length > max_size)
       {
            user_text = user_text.Substring(0, max_size) + "..."; 
       }
       
       Console.WriteLine($"Here is a example of nex shorter text: {user_text}");

       string longest_word = "";
       string temp = "";
       foreach ( string word in input_arr )
       {
        if (word.Length > longest_word.Length)
        {
            longest_word = temp;
            longest_word += word;
        }
       }
       Console.WriteLine($"This is a longest word: {longest_word}");
       
    }

}    