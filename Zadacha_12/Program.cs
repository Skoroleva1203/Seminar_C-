// 12. Удалить вторую цифру трёхзначного числа

int num = 0;

Console.WriteLine ("Выбор варианта для ввода числа.\nTрехзначное число будете вводить - (1) или сгенерировать случайное - (2)?");
Console.Write ("Вариант ответа: ");
int answer = int.Parse (Console.ReadLine()); // Считали ответ, строковую переменную преобразовали в число

if (answer == 1)
    num = GetConsol(100, 999); // Ввели число
else if (answer == 2)
{
    num = new Random().Next(100,999); // Выбрали случайное число
    Console.WriteLine ($"Cгенерировано случайное число {num}");
}    
else
   Console.WriteLine("Необходимо ввести цифру: 1 (Число вводится самостоятельно)\n                     или 2 (Число генерируется случайным образом)");

string numberStr = num.ToString(); // Преобразовали число в строку

Console.WriteLine ($"По условию, из числа {numberStr} требуется удалить вторую цифру {numberStr[1]}");
//numberStr[1] =numberStr[2];
numberStr = numberStr.Remove(1,1); // Метод, возвращает строку, в которой удалено указанное сичло символов в указанной позиции
Console.WriteLine ($"Результат выполнения задания: {numberStr}"); 

int GetConsol(int min, int max) // Число трехзначное?
{
    int result = 0;
    bool isError = true;
    while (isError)
    {
        Console.Write($"Введите целое число от {min} по {max}: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out result))  //Для предупреждения введения неправильного числа
        isError = result < min || result > max;
    }
return result;
}

