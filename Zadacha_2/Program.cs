// Даны два числа. Показать большее и меньшее число

Console.Write("Введите первое число-> ");
string? numberStr_1 = Console.ReadLine();

Console.Write("Введите второе число-> ");
string? numberStr_2 = Console.ReadLine();

int number_1 = int.Parse(numberStr_1); //преобразование из строкой переменной в int
int number_2 = int.Parse(numberStr_2); //преобразование из строкой переменной в int

if (number_1 > number_2)
Console.WriteLine($"{number_1} > {number_2}, соответственно: max -{number_1}, min - {number_2}.");
if (number_1 < number_2)
Console.WriteLine($"{number_1} < {number_2}, соответственно: max -{number_2}, min - {number_1}.");
if (number_1 == number_2)
Console.WriteLine($"Числа равны: {number_1} = {number_2}, минимальное и максимальное значение отсутствует.");
