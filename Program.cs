using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст, завершающийся точкой:");
        string input = Console.ReadLine();

        // Убираем точку в конце для удобства обработки
        if (input.EndsWith("."))
        {
            input = input.TrimEnd('.');
        }

        // Разделяем строку на слова с помощью методов класса string
        string[] words = input.Split(new char[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new StringBuilder();

        // Формируем новую строку с переставленными словами
        for (int i = words.Length - 1; i >= 0; i--)
        {
            result.Append(words[i]);
            if (i > 0)
            {
                result.Append(" "); // Добавляем пробел между словами
            }
        }

        Console.WriteLine("Результат: " + result.ToString());
    }
}