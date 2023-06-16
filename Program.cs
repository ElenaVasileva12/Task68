// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//ввод пользовательских данных
int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

//функции Аккермана
int Ack(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Ack(n - 1, 1);
    }
    else
    {
        return Ack(n - 1, Ack(n, m - 1));
    }
}

//проверка на корректность
bool CheckNaturalNumbers(int num1, int num2)
{
    return num1 > 0 && num2 > 0;
}

int number1 = EnterNumber("Введите  число M");
int number2 = EnterNumber("Введите  число N");

if (CheckNaturalNumbers(number1, number2))
{
    
     Console.WriteLine($"При числе {number1} и {number2} вычисление функции Аккермана равно {Ack(number1, number2)}");
}
else
{
    Console.WriteLine($"Ошибка, число должно быть натуральным");
}