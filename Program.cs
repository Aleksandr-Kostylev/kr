using System;

class Program
{
    static void Main()
    {
        // Пример массива строк
        string[] inputArray = { "Hello", "2", "world", ":-)" };

        // Формирование нового массива из строк длиной не более 3 символов
        string[] resultArray = FilterStrings(inputArray);

        // Вывод результата
        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] input)
    {
        // Считаем количество строк, удовлетворяющих условию
        int count = 0;
        foreach (string str in input)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив с удовлетворяющими условию строками
        string[] result = new string[count];
        int index = 0;
        foreach (string str in input)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }
}

