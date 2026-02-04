using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        DemoStringExtensions();
        DemoArrayExtensions();
        DemoExtendedDictionary();
    }
    static void DemoStringExtensions()
    {
        Console.WriteLine("Методи розширення для String");
        string text = "hello world";

        Console.WriteLine($"Оригінал: {text}");
        Console.WriteLine($"Реверс: {text.ReverseString()}");
        Console.WriteLine($"Кількість l: {text.CountChar('l')}");
    }
    static void DemoArrayExtensions()
    {
        Console.WriteLine("\nМетоди розширення для масивів");
        int[] numbers = { 1, 2, 2, 3, 3, 3, 4 };

        Console.WriteLine("Масив: " + string.Join(", ", numbers));
        Console.WriteLine("Кількість входжень числа 3: " + numbers.CountValue(3));

        int[] unique = numbers.Unique();
        Console.WriteLine("Унікальні елементи: " + string.Join(", ", unique));
    }

    static void DemoExtendedDictionary()
    {
        Console.WriteLine("\nУзагальнений розширений словник");

        var dict = new ExtendedDictionary<int, string, double>();

        dict.Add(1, "Apple", 10.5);
        dict.Add(2, "Orange", 12.0);
        dict.Add(3, "Banana", 8.9);

        Console.WriteLine("Вміст словника:");
        foreach (var item in dict)
            Console.WriteLine(item);

        Console.WriteLine("\nЧи містить ключ 2? " + dict.ContainsKey(2));
        Console.WriteLine("Чи містить значення (Orange, 12.0)? " + dict.ContainsValue("Orange", 12.0));

        Console.WriteLine("\nЕлемент із ключем 3: " + dict[3]);
        dict.Remove(2);

        Console.WriteLine("\nПісля видалення ключа 2:");
        foreach (var item in dict)
            Console.WriteLine(item);

        Console.WriteLine("\nКількість елементів: " + dict.Count);
    }
}