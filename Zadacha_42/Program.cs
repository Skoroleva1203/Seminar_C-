// 42. Определить сколько чисел больше 0 введено с клавиатуры

string InputNumbers() // Метод для корректного ввода числа
{
int cod=0; // Переменная для получения ASCI кода (проверка ввода)
string stroka = " ";
int j;
while (cod < 48 || cod > 58)
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

Console.Write ("Какое количество чисел планируете ввести?  ");
string str = InputNumbers(); // получили число
int n = int.Parse (str); // преобразовали в целое 
Console.WriteLine  ($"\nБудет введено {n} чисел.\n");

int[] arrayNumbers = new int [n]; // Ввод чисел с клавиатуры
int count = 0;
int i = 0;
while (i < n)
{
    string digits = InputNumbers();
    arrayNumbers[i] = int.Parse (digits);
    if (arrayNumbers[i] > 0)
    count++;
    i++;
}

Console.Write($"\nВами введены числа : ");
for (i=0; i<n; i++)
{
    Console.Write($"{arrayNumbers[i]}   ");
}

Console.WriteLine ($"\n\nИз представленных выше чисел {count} положительных (больше 0)/");