// 69. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetRandomNumber ()  //Функция для полчения случайного числа
{
   int randomNumber = new Random().Next(1,50);
   return randomNumber;
}

void PrintSummNaturalNumber(int a, int b) //Метод вычисления суммы и вывода натуральных чисел на консоль
{
    int summ = 0;
    if (a < b)
    {
        for (int c = a; c <= b; c++)
        {
            Console.Write($"{c}  ");
            summ = summ + c;
        }            
    }
    else
    {    
        for (int c = a; c >= b; c--)
        {
            Console.Write($"{c}  ");
            summ = summ + c;        
        }
    }
    Console.WriteLine($"\n\nСумма натуральных чисел от {a} до {b} = {summ}\n");
}

int m = GetRandomNumber(); 
int n = GetRandomNumber(); 
Console.WriteLine($"\nВыведем все натуральные числа от {m} до {n}\n");
PrintSummNaturalNumber(m, n);