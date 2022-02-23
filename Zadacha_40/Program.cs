// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
//Для проверки правильности ввода символов, введенную сроку преобразуем в массив символов, 
// далее каждый символ переводим в ASCI-код и проверяем на его соответствие числу (от 47 до 58) 


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

float[] array = new float[n]; // Создали массив из вещественных чисел

Random rnd = new Random();
for (int i=0; i<n; i++)
{
    array[i] = rnd.Next(); // Заполням массив случайными числами
    Console.Write($"{array[i]}  "); // Вывели на печать
}
Console.WriteLine();
float max = array[0];
float min = array[0];
for (int i=1; i<n; i++)
{
    if (array[i] > max)
    max = array[i];   // Поиск максимального значения
    else
    { 
        if (array[i] < min)
        min = array[i];  // поиск минимального значения
    }
}
Console.WriteLine($"\nМаксимальное значение {max}, минимальное значение {min}.");
Console.WriteLine($"\n{max} - {min} = {max-min}\n");
