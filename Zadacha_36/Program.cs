// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

string InputNumbers() // Метод для корректного ввода числа
{
int cod=0; // Переменная для получения ASCI кода (проверка ввода)
string stroka = " ";
int j;
while (cod < 48 || cod > 58)
{ 
Console.Write ("\nЗадайте длину массива: ");
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

string str = InputNumbers(); // Получили количество элементов в массиве
int n = int.Parse (str); // преобразовали в целое число

int[] array = new int[n]; // 

Random rnd = new Random();
for (int i=0; i<n; i++)
{
    array[i] = rnd.Next(100,1000); // Заполням массив случайными трехзначными числами
    Console.Write($"{array[i]}  "); // Вывели на печать
}
Console.WriteLine();
int countChet = 0;
int countNechet = 0;
for (int i=0; i<n; i++)
{
    int ostatok = array[i] % 2;
    if (ostatok == 0)
    {    
        countChet++;
    }
    else
    {   
    countNechet++;
    } 
}
Console.Write($"\nВ массиве {countChet} четных чисел и {countNechet} нечетных чисел.");