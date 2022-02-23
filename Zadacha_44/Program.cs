// 44: Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

// Путем преобразования через систему уравнений получаем x = (b2-b1) / (k1-k2)

string InputNumbers() // Метод для корректного ввода числа
{
    int cod=0; // Переменная для получения ASCI кода (проверка ввода)
    string stroka = " ";
    int j;
    while (cod < 48 || cod > 58 )
{ 
    Console.Write ("Введите число: ");
    stroka = Console.ReadLine();
    char[] arr; // Задали массив для перевода из строки в массив символов
    arr = stroka.ToCharArray(); // Преобразовали в массив символов
    for (j =0; j < arr.Length; j++)
    {
        cod = Convert.ToByte(arr[j]); // Получили код ASCI
        //Console.Write(cod ); 
    }    
} 
    return stroka;
}


void TochkaPeresech (float k11, float b11, float k22, float b22) // Метод поиска точки пересечения
{
    float koordX = (b22-b11) / (k11-k22);
    float koordY = k22*koordX+b22;
    Console.WriteLine($"Точка ( {koordX},  {koordY} ) является точкой пересечения двух прямых, выраженных уравнениями: y = {k11}*x + {b11} и y = {k22}*x + {b22}.\n");
}

Console.Write ("Присваиваем значение числу b1: ");
string str = InputNumbers(); // получили число
int b1 = int.Parse (str); // преобразовали в целое 

Console.Write ("Присваиваем значение числу k1: ");
str = InputNumbers(); // получили число
int k1 = int.Parse (str); // преобразовали в целое 

Console.Write ("Присваиваем значение числу b2: ");
str = InputNumbers(); // получили число
int b2 = int.Parse (str); // преобразовали в целое 

Console.Write ("Присваиваем значение числу k2: ");
str = InputNumbers(); // получили число
int k2 = int.Parse (str); // преобразовали в целое 

Console.WriteLine  ($"\n b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}  .\n");
if (k1 != k2)
    {
    TochkaPeresech (k1, b1, k2, b2);
    }
else
    {
    Console.WriteLine ($"При заданных k1 = k2 = {k1} прямые параллельны друг другу.");
    }
