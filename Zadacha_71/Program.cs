// 71. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int GetRandomNumber ()  //Функция для полчения случайного числа
{
   int randomNumber = new Random().Next(0,5);
   return randomNumber;
}

int FAkkermana(int a, int b) //Метод вычисления функции Аккермана
{
    if (a == 0)
        return  b + 1;
    else
        if ((a > 0) && (b == 0))
        return FAkkermana(a - 1, 1);
    else
        return FAkkermana(a - 1, FAkkermana(a, b-1));
}

int m = GetRandomNumber(); 
int n = GetRandomNumber(); 
Console.WriteLine($"\nВычислим функцию Аккермана для А ({m}, {n})\n");
Console.WriteLine($"А ({m}, {n}) = {FAkkermana(n, m)}");