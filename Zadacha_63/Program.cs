// 63. Сформировать трехмерный массив не повторяющимися двузначными числами 
//показать его построчно на экран выводя индексы соответствующего элемента

using System;
string InputNumbers() // Метод для корректного ввода числа
{
    int cod=0; // Переменная для получения ASCI кода (проверка ввода)
    string stroka = " ";
    int j;
    while (cod < 47 || cod > 58 )
    { 
        Console.Write ("Введите число: ");
        stroka = Console.ReadLine();
        char[] arr; // Задали массив для перевода из строки в массив символов
        arr = stroka.ToCharArray(); // Преобразовали в массив символов
        for (j =0; j < arr.Length; j++)
        {
            cod = Convert.ToByte(arr[j]); // Получили код ASCI
        }    
    } 
    return stroka;
}

void PrintMatrix (double[,,] matrix) // Метод вывода массива на консоль
{    
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int k = 0; k < matrix.GetLength(2); k++)  // Выборка глубины
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.WriteLine ($"[{i},{j},{k}] = {matrix[i,j,k]}");                 
}

Console.WriteLine ("Введите размерность трехмерного массива.");
Console.Write("Число строк.  ");
string str = InputNumbers(); 
int n = int.Parse (str); 
Console.Write("Число столбцов.  ");
str = InputNumbers(); 
int m = int.Parse (str); 
Console.Write("Число глубины.  ");
str = InputNumbers(); 
int z = int.Parse (str); 
double[,,] array = new double [n, m, z];

int count = 10;
for (int i = 0; i < n; i++) // Заполняем массив 
    for (int j = 0; j < m; j++)
        for (int k = 0; k < z; k++)
            array[i, j, k] = count++;
              
  
Console.WriteLine("Трехмерный массив");
PrintMatrix(array);
Console.WriteLine("\n");
 

