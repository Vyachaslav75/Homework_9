// Программа выводит все натуральные числа от N до 1.

int enterNumber(string msg, string errorMsg)
{
    int number;
    while (true)
    {
        Console.Write(msg);
        if (int.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        Console.WriteLine(errorMsg);
    }
}

string LineNumber(int num)
{
    if (num == 1) return num.ToString();
    return num.ToString() + ", " + LineNumber(num - 1);
}

Console.Clear();
int number = enterNumber("Введите число:  ", "Введите целое число");
Console.WriteLine($"N={number} -> '{LineNumber(number)}'");
