// 42. Написать программу масштабирования фигуры
using System.Linq;

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
        //Console.Write(cod ); 
    }    
} 
return stroka;
}

string text = "(2,4) (4,8) (8,10) (10,13)"
              .Replace("(","")  // Скобки меняем на пробел
              .Replace(")","")
              ;
Console.WriteLine (text);

Console.WriteLine ("\nЗадайте коэффициент для изменения маштаба фигуры.");
string str = InputNumbers(); // получили число
double k = double.Parse (str); // преобразовали в вещественное

var data = text.Split(" ") // Разбить текст
               .Select(item => item.Split(',')) // разбить текст с учетом разделителя - запятой
               .Select(e => (x: double.Parse(e[0]), y: double.Parse(e[1]))) // Сделать выборку и перевести элементы массива в числовой (целый) тип
               .Select(point => (point.x * k, point.y * k)) // Увеличиваем маштаб
               .ToArray(); 

Console.WriteLine ($"\nИзменяем маштаб в {k} раз.");

for (int i = 0; i < data.Length; i++)
    Console.WriteLine(data[i]);