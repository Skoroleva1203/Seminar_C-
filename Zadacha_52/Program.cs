// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

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

Console.WriteLine ("Введите размерность массива.");
Console.Write("Число строк.  ");
string str = InputNumbers(); 
int n = int.Parse (str); 
Console.Write("Число столбцов.  ");
str = InputNumbers(); 
int k = int.Parse (str); 
double[,] array = new double [n , k];
   
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < k; j++)
            {
            array[i,j] = rnd.Next(-100,101); // Заполням массив случайными числами
            Console.Write ($"{array [i,j]}    ");
            }
    }   
Console.WriteLine("\n");

for (int i = 1; i < n; i++)
    {
        for (int j = 1; j < k; j++)
            {
                if (i%2 == 0 && j%2 == 0 ) // Проверка на четность двух индексов
               
                Console.WriteLine($"У элемента [{i},{j}] = {array[i,j]} четные индексы");
                array[i,j] = Math.Pow(array[i,j],2);
            }
    }   

Console.WriteLine ("\n\nРезультат замены элементов массива с четными индексами (i, j) на его квадрат");
for (int i = 0; i < n; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < k; j++)
            {
            Console.Write ($"{array [i,j]}    ");
            }
    }   
