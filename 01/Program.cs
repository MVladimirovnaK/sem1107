// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y: ");
int y= Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка принадлежит первой четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка принадлежит второй четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка принадлежит третьей четверти");
}
else if (x > 0 && y < 0)
{
     Console.WriteLine("Точка принадлежит четвертой четверти");
}
else 
{
    Console.WriteLine("Точка лежит на оси");
}