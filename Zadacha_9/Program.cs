// Показать последнюю цифру трёхзначного числа

int Get(int number)   // Метод для деления числа и нахождения остатка? который будет последней цифрой в числе
{
    return number % 10;
}

int GetConsol(int min, int max) // Число техзначное?
{
    int result = 0;
    bool isError = true;
    while (isError)
    {
        Console.Write($"Введите целое число от {min} по {max}: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out result))  //Для предупреждения введения неправильного числа
        isError = result < min || result > max;
    }
return result;
}

int number = GetConsol (100, 999);
int LastDigit = Get(number);
Console.WriteLine(LastDigit);


