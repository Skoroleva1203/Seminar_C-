// 22. Найти расстояние между точками в пространстве 2D/3D

// Формула для вычисления расстояние мужду двумя точками A(xa, ya) и B(xb, yb) на плоскости  AB = корень кв. из ((xb - xa)2 + (yb - ya)2)
// формцла для вычисления расстояния между двумя точкамми A(xa, ya, za) и B(xb, yb, zb)в простарнстве АВ = корень кв. из (xb - xa)2 + (yb - ya)2 + (zb - za)2
//

void Distance2D (int x1, int y1, int x2, int y2) // Метод для вычисления расстояния между двумя точками на плоскости
{
   double dist = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
   Console.WriteLine ($"Расстояние между точками А ({x1}, {y1}) и В ({x2}, {y2}) = {dist}");
}

void Distance3D (int x1, int y1, int z1, int x2, int y2, int z2) // Метод для вычисления расстояния между двумя точками в пространстве
{
   double dist = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
   Console.WriteLine ($"Расстояние между точками А ({x1}, {y1}, {z1}) и B ({x2}, {y2}, {z2}) = {dist}");
}

Console.WriteLine("Зададим координаты точек при помощи генератора случайных чисел");
Console.WriteLine();
int xa = new Random().Next(-100,100); // Координата Xa точки А
int ya = new Random().Next(-100,100); // Координата Ya точки А
int xb = new Random().Next(-100,100); // Координата Xb точки В
int yb = new Random().Next(-100,100); // Координата Yb точки В
int za = new Random().Next(-100,100); // Координата Za точки А (в пространстве)
int zb = new Random().Next(-100,100); // Координата Zb точки В (в простарнстве)

Console.WriteLine ($"Координаты точки A на плоскости ({xa}, {ya})");
Console.WriteLine ($"Координаты точки B на плоскости ({xb}, {yb})");
Console.WriteLine();
Distance2D (xa, ya, xb, yb);
Console.WriteLine();
Console.WriteLine ($"Координаты точки A в простарнстве ({xa}, {ya}, {za})");
Console.WriteLine ($"Координаты точки B в простарнстве ({xb}, {yb}, {zb})");
Console.WriteLine();
Distance3D (xa, ya, za, xb, yb, zb);
Console.WriteLine();