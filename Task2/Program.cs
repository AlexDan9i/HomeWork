
//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n. 
//m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите два неотрицательных целых числа m и n:");

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

if (m > 0 && n > 0)
{

    // Вычисляем значение функции Аккермана A(m, n)
    int result = Ackermann(n, m);

    Console.WriteLine($"Значение функции Аккермана A({m}, {n}) = {result}");

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }

        if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }

        if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }

        return -1; // Этот возврат не выполняется, если все условия выполнены
    }
}
else Console.WriteLine("Ошибка! Вы ввели отрицательное число, программа будет закрыта.");