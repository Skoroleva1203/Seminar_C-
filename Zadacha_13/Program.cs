// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int GetRandomNumber ()  //Функция для полчения случайного числа
{
   int randomNumber = new Random().Next(20,100);
   return randomNumber;
}

void IsMultiple (int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        int result = firstNumber % secondNumber;
        if (result == 0)
            Console.WriteLine($"Число {firstNumber} кратно {secondNumber}, остаток {result}");
        else
            Console.WriteLine($"Число {firstNumber} не кратно {secondNumber}, остаток {result}");
    }
    else 
    {        
        int result = firstNumber % secondNumber;
        if (result == 0)
            Console.WriteLine($"Число {secondNumber} кратно {firstNumber}, остаток {result}");
        else
            Console.WriteLine($"Число {secondNumber} не кратно {firstNumber}, остаток {result}");
    }
}
int number = GetRandomNumber(); // Получили какое-то случайное число
Console.WriteLine($"Первое случайное число: {number}");

int delitel = GetRandomNumber(); //Случайное второе число

Console.WriteLine($"Второе случайное число: {delitel}");

IsMultiple(number, delitel);