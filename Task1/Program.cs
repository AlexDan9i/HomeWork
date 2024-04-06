//Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа
//в промежутке от M до N. Использовать рекурсию, не использовать циклы.

//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.WriteLine("Введите два целых число M :");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите два целых число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа в промежутке от {m} до {n} :");

PrintNaturalNumbers(m, n);

static void PrintNaturalNumbers(int start, int end)
{
    if (start <= end)
    {
        Console.Write($"{start} ");            // Выводим текущее число
        PrintNaturalNumbers(start + 1, end); // Рекурсивный вызов для следующего числа
    }
}
