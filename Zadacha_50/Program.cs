// 50: В двумерном массиве n×k заменить четные элементы на противоположные.

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
        }    
    } 
    return stroka;
}

void FillArray (int[,] matr) // Метод заполнения массива случайными часлами и вывода на консоль
{   
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matr.GetLength(1); j++)
            {
            matr[i,j] = rnd.Next(-100,101); // Заполням массив случайными числами
            Console.Write ($"{matr [i,j]}    ");
            }
    }   
Console.WriteLine("\n");
}   

void ReplacOpposite(int[,] matrix) // Метод 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i,j]%2 == 0) // Проверка на четность
                matrix[i,j] = -matrix[i,j];
            }
    }   
}    
    
void PrintMatrix(int[,] mat)    // вывод массива на консоль
{    
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write ($"{mat [i,j]}    ");
        }
    }   
}

Console.WriteLine ("Введите размерность массива.");
Console.Write("Число строк.  ");
string str = InputNumbers(); 
int n = int.Parse (str); 
Console.Write("Число столбцов.  ");
str = InputNumbers(); 
int k = int.Parse (str); 
int[,] array = new int [n , k];
   
FillArray(array); // Заполнили случайными часлами
ReplacOpposite(array); // Замена определенных элементов на противоположные
Console.WriteLine ("\nРезультат замены четных элемнетов массива на противоположные");
PrintMatrix(array);