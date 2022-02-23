// 48: Показать двумерный массив размером m×n заполненный целыми числами.

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

Console.WriteLine ("Введите размерность массива.");
Console.Write("Число строк.  ");
string str = InputNumbers(); 
int m = int.Parse (str); 
Console.Write("Число столбцов.  ");
str = InputNumbers(); 
int n = int.Parse (str); 

int[,] array = new int [m , n];

Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    Console.WriteLine();
    for (int j = 0; j < n; j++)
        {
        array[i,j] = rnd.Next(); // Заполням массив случайными числами
        Console.Write ($"{array [i,j]}    ");
        }
}    
