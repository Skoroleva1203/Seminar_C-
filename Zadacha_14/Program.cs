// Найти третью цифру числа или сообщить, что её нет

int num = 0;
Console.WriteLine ("Выбор варианта ответа для ввода числа.\nЧисло будете вводить? - (1) или сгенерировать случайное? - (2)?");
Link_1: // Возвращение к выбору ответа, при введении неправильного символа
Console.Write ("Вариант ответа: ");
int answer = int.Parse (Console.ReadLine()); // Считали ответ, строковую переменную преобразовали в число

if (answer == 1)
{
    Console.WriteLine ("Введите любое число");
    num = int.Parse(Console.ReadLine()); // Ввели число, преобразовали в целое
}
else if (answer == 2)
{
    Random rnd = new Random(); // Создали объект для генерации чисел
    num = rnd.Next(); // Получили случайное число 
    Console.WriteLine ($"Cгенерировано случайное число {num}");
}    
else // Предупреждение, что при выборе ответа был введен неверный символ
{  
   Console.WriteLine("Необходимо ввести цифру: 1 (Число вводится самостоятельно)\n                     или 2 (Число генерируется случайным образом)");
   goto Link_1;
}
string numberStr = num.ToString(); // Преобразовали число в строку
int length = numberStr.Length; // Нашли длину строки
if (length < 3)
    Console.WriteLine($"Теретья цифра отсутствует, т.к. число {numberStr} состоит из {length} цифр.");
Console.WriteLine ($"Третья цифра числа {numberStr}  - это {numberStr[2]}");


