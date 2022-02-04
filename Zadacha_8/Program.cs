 // Показать четные числа от 1 до N

Console.Write ("Введите число N = ");  
string? number = Console.ReadLine ();  // Задали длину массива
int n = int.Parse(number);  

int[] array = new int[n];  // Инициализировали массив длиной N

NewArray ( array ); // Заполнили массив с помощью функции

PrintArray(array); // Распечатали, для проверки с помощью созданной функции

Console.WriteLine();
Console.WriteLine("Четные числа в массиве");
EvenNumber (array);

void NewArray(int[] mac)  // Функция для заполнения массива случайными числами
{
    int  i  =  0 ;
    while (i < (n-1))
    {
        mac[i] = new Random().Next(1, n);
        i++;
    }
}

void PrintArray(int[] col) // Функция для распечатки массива
{
    int count = col.Length;
    int  position  =  0;
    while (position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
}

void EvenNumber (int[] col) // Функция для поиска четных чисел
{
 int count = col.Length;
    int  position  =  0;
    int ost = 0;
    while (position < count)
    {
        if (col[position] == 0)
           position++;
        else
        {
           ost = col[position]%2;  
           if (ost == 0) 
           Console.Write($"{col[position]}, ");
           position++;
        }
    }
} 