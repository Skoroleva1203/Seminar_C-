// Является ли первое число квадратом второго

Console.Write("Введите первое число-> ");
string? numberStr_1 = Console.ReadLine();

Console.Write("Введите второе число-> ");
string? numberStr_2 = Console.ReadLine();

int number_1 = int.Parse(numberStr_1); //преобразование из строкой переменной в int
int number_2 = int.Parse(numberStr_2); //преобразование из строкой переменной в int

if (number_1 == number_2*number_2)
Console.WriteLine($"Квадрат числа: {number_2} = {number_1}");
else
Console.WriteLine($"Число: {number_1} не является квадратом числа {number_2}");
