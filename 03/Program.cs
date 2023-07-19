// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Write("Введите x первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
result = Math.Round(result,2);
Console.WriteLine($"Расстояние между точками: {result}");