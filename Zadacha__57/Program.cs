// 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерной массива.
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

void StringSorting(double[,] mas, int i) // Метод для сотрировки одной строки
{
    int ind; // Переменная для хранения индекса минимального элемента массива
    for (int j = 0; j < mas.GetLength(1); j++ ) // Проходим по строке от начала до конца
    {
        ind = j; // Считаем, что минимальный элемент имеет текущий индекс
        for (int n = j; n < mas.GetLength(1); n++) // ищем минимальный элемент 
        {
            if (mas[i,n] < mas[i,ind])
            {
                ind = n; // Нашли в строке число меньшее, чем mas[ind]
            }
        }
        if (mas[i,ind] == mas[i,j]) // Есло минимальный элемент равен текущему значению, то ничего не меняем
            continue;
        double temp = mas[i,j]; // Временная переменная
        mas[i,j] = mas[i,ind];
        mas[i,ind] = temp;
    }
}

void ArraySorting(double[,] massiv) // Метод сортировки всех строк массива
{
    for (int i = 0; i < massiv.GetLength(0); i++) 
        StringSorting(massiv, i);     
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
ArraySorting(array);
Console.WriteLine ("\n\nРезультат сортировки строк");
PrintMatrix(array);