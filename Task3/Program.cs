//Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.
//[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


Console.WriteLine("Введите элементы массива целых чисел (разделяйте числа пробелами):");
string input = Console.ReadLine(); // Считываем строку ввода

// Разбиваем строку на подстроки (элементы массива) по пробелам
string[] inputElements = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

// Определяем размер массива
int arraySize = inputElements.Length;
int[] arr = new int[arraySize]; // Создаем массив нужного размера

// Заполняем массив значениями, проверяя каждое значение на корректность
for (int i = 0; i < arraySize; i++)
{
    if (int.TryParse(inputElements[i], out int number))
    {
        arr[i] = number; // Записываем число в массив
    }
    else
    {
        Console.WriteLine($"Ошибка: Неверный формат числа '{inputElements[i]}'.");
        return; // Завершаем программу в случае ошибки
    }
}

Console.WriteLine("Элементы массива, начиная с конца:");
PrintArrayReverse(arr, arr.Length - 1); // Вызываем функцию для вывода элементов с конца


static void PrintArrayReverse(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.Write($"{arr[index]} "); // Выводим элемент массива с текущим индексом (с конца)
        PrintArrayReverse(arr, index - 1); // Рекурсивно вызываем функцию для следующего элемента
    }
}
