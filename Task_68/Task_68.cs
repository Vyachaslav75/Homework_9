// Программа вычисляет функцию Аккермана для неотрицательных чисел m и n .

int enterNumber(string msg, string errorMsg)
{
    int number;
    while (true)
    {
        Console.Write(msg);
        if (int.TryParse(Console.ReadLine(), out number) && number > 0)
        {
            return number;
        }
        Console.WriteLine(errorMsg);
    }
}

int Akkerman(int numberN, int numberM)
{
    if (numberN == 0)
    {
        return numberM + 1;
    }
    else
    {
        if (numberN > 0 && numberM == 0)
        {
            return Akkerman(numberN - 1, 1);
        }
        else
        {
            return Akkerman(numberN - 1, Akkerman(numberN, numberM - 1));
        }
    }
}

Console.Clear();
int numberM = enterNumber("Введите число m:  ", "Введите целое неотрицательное число");
int numberN = enterNumber("Введите число n:  ", "Введите целое неотрицательное число");
Console.WriteLine($"m={numberM}, n={numberN} -> {Akkerman(numberM, numberN)}");