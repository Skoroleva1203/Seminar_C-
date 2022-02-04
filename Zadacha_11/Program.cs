// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int GetRandomNumber ()
{
   int randomNumber = new Random().Next(10,100);
   return randomNumber;
}

int number = GetRandomNumber();
Console.WriteLine(number);
int numberOne =  number / 10;
int numberTwo = number % 10;

if (numberOne > numberTwo)
    Console.WriteLine($"Наибольшее из цифр {numberOne}");
else
    Console.WriteLine($"Наибольшее из цифр {numberTwo}");




