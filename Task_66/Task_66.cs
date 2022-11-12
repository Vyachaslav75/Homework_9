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

int SumDigits(int numM, int numN)
{
    if (numM == numN) return numM;
    return numM + SumDigits(numM + 1, numN);
}

Console.Clear();
int numberM = enterNumber("Введите число M:  ", "Введите целое число");
int numberN = enterNumber("Введите число N:  ", "Введите целое число");
Console.WriteLine($"M={numberM}; N={numberN} -> {SumDigits(numberM, numberN)}");
