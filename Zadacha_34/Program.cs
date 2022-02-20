// 34. Написать программу замены элементов массива на противоположные

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

int[] array = new int[n]; // Задали массив из N элементов
Console.WriteLine($"Создали массив из {n} элементов\n");
Random rnd = new Random();
for (int i=0; i<n; i++)
{
    array[i] = rnd.Next(); // Заполням массив случайными числами
    Console.Write($"{array[i]}  "); // Вывели на печать
}
Console.WriteLine("\n");
for (int i=0; i<n; i++)
{
    array[i] = -array[i]; // Меняем элементы на противоположные
    Console.Write($"{array[i]}  "); // Вывели на печать
}