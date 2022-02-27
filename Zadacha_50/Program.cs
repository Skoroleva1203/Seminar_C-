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

Console.WriteLine ("Введите размерность массива.");
Console.Write("Число строк.  ");
string str = InputNumbers(); 
int n = int.Parse (str); 
Console.Write("Число столбцов.  ");
str = InputNumbers(); 
int k = int.Parse (str); 
int[,] array = new int [n , k];
   
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < k; j++)
            {
            array[i,j] = rnd.Next(); // Заполням массив случайными числами
            Console.Write ($"{array [i,j]}    ");
            }
    }   


 for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
            {
                if (array[i,j]%2 == 0) // Проверка на четность
                array[i,j] = -array[i,j];
            }
    }   

Console.WriteLine ("\n\nРезультат замены четных элемнетов массива на противоположные");
for (int i = 0; i < n; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < k; j++)
            {
            Console.Write ($"{array [i,j]}    ");
            }
    }   