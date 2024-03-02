using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "текст з числами 123 та лiтерами ABC змiшаними 45abc";
        char[] separators = new char[] { ' ', '.', ',', '!', '?' };
        List<string> words = new List<string>(text.Split(separators, StringSplitOptions.RemoveEmptyEntries));

        Console.WriteLine($"Загальна кiлькiсть елементiв: {words.Count}");

        Console.Write("Введiть iндекс елемента та напрямок (вперед/назад): ");
        string[] inputs = Console.ReadLine().Split(' ');
        int index = int.Parse(inputs[0]);
        string direction = inputs[1].ToLower();

        if (direction == "вперед")
        {
            for (int i = index; i < words.Count; i++)
                Console.WriteLine(words[i]);
        }
        else if (direction == "назад")
        {
            for (int i = index; i >= 0; i--)
                Console.WriteLine(words[i]);
        }
        else
        {
            Console.WriteLine("Невiрний напрямок!");
        }

        Console.WriteLine("Натиснiть будь-яку клавiшу для виходу...");
        Console.ReadLine();
    }
}
