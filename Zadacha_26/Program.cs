// 26. Возведите число А в натуральную степень B используя цикл
// Натуральная степень - это числа больше и не равные нулю (1, 2, 3, ...)
double result = 1;
Console.Write ("Введите число, которое необходимо возвести в степень: ");
int numberA = int.Parse (Console.ReadLine()); // Считали ответ, строковую переменную преобразовали в число A
Console.Write ("Введите число натуральное число В (степень, в которую необходимо возвести число A): ");
int stepen = int.Parse (Console.ReadLine()); // Считали ответ, строковую переменную преобразовали в число B
while (stepen < 0 || stepen == 0)
{
    Console.WriteLine ("Необходимо ввести натуральное число, т.е. с выполнением условия B > 0.");
    Console.Write ("Повторите ввод числа: ");
    stepen = int.Parse (Console.ReadLine()); // Считали ответ, строковую переменную преобразовали в число B
}
for (int count = 1; count <=stepen; count++)
   { 
       result = result *  numberA;
   }
Console.WriteLine ($"{numberA} в степени {stepen} = {result}");

