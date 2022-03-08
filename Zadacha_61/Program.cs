// 61: Найти произведение двух матриц

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
   int randomNumber = new Random().Next(-100,101);
   return randomNumber;
}

void FillArray (int[,] matr) // Метод заполнения массива случайными числами
{    
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i,j] = GetRandomNumber();   
}

void PrintMatrix (int[,] matrix) // Метод вывода массива на консоль
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

int ArraySize() // Метод для ввода размерности массива
{
    string str = InputNumbers(); 
    int f = int.Parse (str); 
    return f;
}

static int[,] ProductTwoMatrix (int[,] onematrix, int[,] twomatrix)
{
    int a = onematrix.GetLength(0);
    int b = twomatrix.GetLength(1);
    var matrixC = new int [a, b];
    for (int c = 0; c < onematrix.GetLength(0); c++)
    {
        for (int d = 0; d < twomatrix.GetLength(1); d++)
        {    
            matrixC[c,d] = 0;
            for (int k = 0; k < onematrix.GetLength(0); k++)
            {    
                matrixC[c,d] += onematrix[c,k] * twomatrix[k,d];
            }
        }
    }
    return matrixC;
}

Console.WriteLine ("Для нахождения произведения двух матриц необходимо выполнение условия:");
Console.WriteLine ("Количество СТОЛБЦОВ первой матрицы должно быть равным количеству СТРОК второй матрицы!!!\n");
Console.WriteLine ("Введите размерность первого массива.");
Console.Write("Число строк.  ");
int n = ArraySize();
Console.Write("Число столбцов.  ");
int m = ArraySize();
int[,] array = new int [n , m];
FillArray(array);
Console.WriteLine("\nЗаполнили первый массив");
PrintMatrix(array);
Console.WriteLine("\n");
Console.WriteLine ("Введите размерность второго массива.");
Console.Write("Число строк.  ");
int c = ArraySize();
Console.Write("Число столбцов.  ");
int d = ArraySize();
int[,] massiv = new int [c, d];
Console.WriteLine("\nЗаполнили второй массив");
FillArray(massiv);
PrintMatrix(massiv);

if (array.GetLength(1) == massiv.GetLength(0))
{
    Console.WriteLine("\n\nРЕЗУЛЬТАТ перемножения двух матриц");
    PrintMatrix(ProductTwoMatrix (array, massiv));
}
else
    Console.WriteLine("\nПроизведение данных матриц найти НЕВОЗМОЖНО, т.к. число столбцов первой матрицы не совпадает с числом строк второй матрицы");
 
