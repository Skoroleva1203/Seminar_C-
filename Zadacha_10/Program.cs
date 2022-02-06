// 10. Показать вторую цифру трёхзначного числа

int Get(int number)   // Функция для нахождения второй цифры в трехзначном числе
{
    number = number / 10;   
    return number % 10;
}

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

void Resalt (int num)  //Функция для вывода второй цифры
{
 int resalt = Get(num);
 Console.WriteLine(resalt);
}

int num=0; 
Console.WriteLine ("Выбор варианта для ввода числа.\nTрехзначное число будете вводить - (1) или сгенерировать случайное - (2)?");
Console.Write ("Вариант ответа: ");
int answer = int.Parse (Console.ReadLine());

if (answer == 1)
{   
    num = GetConsol(100, 999); // Ввели число
    Resalt (num);    
}
else if (answer == 2)
{
    num = new Random().Next(100,999); // Выбрали случайное
    Console.WriteLine ($"Cгенерировано случайное число {num}");
    //int resalt = Get(num);
    //Console.WriteLine(resalt);
     Resalt (num);    
}    
else
   Console.WriteLine("Необходимо ввести цифру: 1 (Число вводится самостоятельно)\n                     или 2 (Число генерируется случайным образом)");
