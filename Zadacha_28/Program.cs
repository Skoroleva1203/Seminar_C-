// 28. Подсчитать сумму цифр в числе

int num = 0;
int summa = 0;
int digit; 
Random rnd = new Random(); // Создали объект для генерации чисел
num = rnd.Next(); // Получили случайное число 
Console.WriteLine ($"\nCгенерировано случайное число {num}");

// Находим количество цифр в числе
string numberStr = num.ToString(); // Преобразовали число в строку
int length = numberStr.Length; // Нашли длину строки = количеству цифр в числе
Console.Write($"Число {num} состоит из {length} цифр.\nНайдем сумму данного числа\n");
int num_1 = num;
int i = 0;
int resalt = 1;
while (i<length) 
{
int ost = num_1 % 10;  // Ищем остаток
Console.Write($"\nОстаток {ost}.  ");
summa = summa + ost; //Считаем сумму
Console.Write($"Сумма {summa}.");
resalt = num_1 / 10;
Console.WriteLine($"\nИщем остаток от числа {resalt}.");
num_1 = resalt;
i++;
}
Console.WriteLine ($"\nСумма цифр числа {num} = {summa}.\n");