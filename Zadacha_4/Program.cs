// Найти максимальное из трех чисел

Console.Write("Введите первое число-> ");
string? numberStr_1 = Console.ReadLine();

Console.Write("Введите второе число-> ");
string? numberStr_2 = Console.ReadLine();

Console.Write("Введите третье число-> ");
string? numberStr_3 = Console.ReadLine();

int number_1 = int.Parse(numberStr_1); //преобразование из строкой переменной в int
int number_2 = int.Parse(numberStr_2);
int number_3 = int.Parse(numberStr_3);  
int max=number_1, min=number_1;

if (max > number_2 && max > number_3)
Console.WriteLine($"Максимальное число {number_1}.");
if (min < number_2 && min < number_3)
Console.WriteLine($"Минимальное число {number_1}.");
else
{
    max = number_2; 
    min = number_2;
}
if (max > number_1 && max > number_3)
Console.WriteLine($"Максимальное число {number_2}.");
if (min < number_1 && min < number_3)
Console.WriteLine($"Минимальное число {number_2}.");
else
{
    max = number_3; 
    min = number_3;
}
if (max > number_1 && max > number_2)
Console.WriteLine($"Максимальное число {number_3}.");
if (min < number_1 && min < number_2)
Console.WriteLine($"Минимальное число {number_3}.");

Console.WriteLine("Не проверили на равенство чисел");




