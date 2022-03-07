// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int GetRandomNumber ()  //Функция для полчения случайного числа
{
   int randomNumber = new Random().Next(1,50);
   return randomNumber;
}

void PrintNaturalNumber(int a, int b) //Метод вывода натуральных числе на консоль
{
    if (a < b)
    {
        for (int c=a; c <= b; c++)
            Console.Write($"{c}  ");
    }
    else
    {    
        for (int c=a; c >= b; c--)
            Console.Write($"{c}  ");
    }
}

int m = GetRandomNumber(); 
int n = GetRandomNumber(); 
Console.WriteLine($"\nВыведем все натуральные числа от {m} до {n}\n");
PrintNaturalNumber(m, n);