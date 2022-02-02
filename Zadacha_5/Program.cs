// Является ли число четным
int number = new Random().Next(1, 20); // Случайное число
Console.WriteLine(number);
int ost = 0;
ost = number%2;
if (ost == 0)
Console.WriteLine($"Число {number} четное.");
else
Console.WriteLine($"Число {number} нечетное.");
