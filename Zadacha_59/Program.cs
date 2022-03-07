// 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int GetRandomNumber ()  //Функция для полчения случайного числа
{
   int randomNumber = new Random().Next(1,50);
   return randomNumber;
}

void PrintMatrix (double[,] matrix) // Метод вывода массива на консоль
{    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write (matrix[i,j] + "\t");
        }
    }   
}

double SummaString(double[,] mas, int i) // Метод для подсчета суммы одной строки
{
    double summa = 0;
    for (int j = 0; j < mas.GetLength(1); j++ ) 
        summa = summa + mas[i,j];
    Console.WriteLine($"Сумма {i} строки = {summa}");
    return summa;    
}

void ArraySummaString(double[,] massiv) // Метод для поиска наименьшей суммы
{
    double[] summa = new double [massiv.GetLength(0)];
    for (int i = 0; i < massiv.GetLength(0); i++) 
        summa[i] = SummaString(massiv, i);     // Заполнили массив элементами, равными сумме строк двумерного массива
    Array.Sort(summa); // после сортировки одномерного массива - первый элемент наименьший
    Console.WriteLine($"\nНАИМЕНЬШАЯ СУММА = {summa[0]}\n");
}

Console.WriteLine ("Введите размерность массива.");
Console.Write("Число строк.  ");
string str = InputNumbers(); 
int n = int.Parse (str); 
Console.Write("Число столбцов.  ");
str = InputNumbers(); 
int m = int.Parse (str); 
double[,] array = new double [n , m];
for (int i = 0; i < n; i++) // Заполняем массив случайными числами
{
    for (int j = 0; j < m; j++)
    array[i,j] = GetRandomNumber ();
}   

Console.WriteLine("Первоначальный вид массива");
PrintMatrix(array);
Console.WriteLine("\n");
ArraySummaString(array);

