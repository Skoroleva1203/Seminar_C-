// 54: В матрице чисел найти сумму элементов главной диагонали

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

void FillArray (double[,] matr) // Метод заполнения массива случайными часлами и вывода на консоль
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

void MainDiagonal (double[,] matrix) //Метод  посчета и вывода на косоль суммы элементов главной диагонали массива
{   
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j ) // Проверка на четность двух индексов
                    {
                        Console.WriteLine($"Элемент [{i},{j}] = {matrix[i,j]} принадлежит главной диагонале матрицы");
                        sum = sum + matrix[i,i];
                    }
                }
        }   
    Console.WriteLine ($"\nСумма главной диагонали матрицы = {sum}");
}

Console.WriteLine ("Введите размерность массива.");
Console.Write("Число строк.  ");
string str = InputNumbers(); 
int n = int.Parse (str); 
Console.Write("Число столбцов.  ");
str = InputNumbers(); 
int k = int.Parse (str); 
double[,] array = new double [n , k];
   
FillArray(array); 
MainDiagonal(array);


