// 30. Показать кубы чисел, заканчивающихся на четную цифру
 
int number = 1;
int num = new Random().Next(1, 50); // Создали объект для генерации чисел
Console.WriteLine ($"Cгенерировано случайное число {num}");
Console.WriteLine ($"Кубы чисел в пределах от 1 до {num} заканчиваются на четную цифру: ");
   
for (number=1; number<= num; number++)
{
    double cube = Math.Pow(number, 3); // Заданное число возвели в куб
    if ((cube%2) == 0) // Посик четного числа 
    Console.WriteLine ($"{number} в кубе = {cube}");  
}