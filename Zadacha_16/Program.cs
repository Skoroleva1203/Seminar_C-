//16: Дано число, обозначающее день недели. Выяснить является номер дня недели выходным.

Console.WriteLine ("Введите порядкой номер деня недели ( от 1 до 7 ): ");
int day = int.Parse (Console.ReadLine()); // Считали ответ, строковую переменную преобразовали в число

if (day < 1 || day > 7)
Console.WriteLine ("Введите корректное число от 1 до 7.");
else if (day == 6 || day == 7)
Console.WriteLine ($"Введенный вами день недели {day} является выходным днем");
else
Console.WriteLine ($"Введенный вами день недели {day} не является выходным днем");
