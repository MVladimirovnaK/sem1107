﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int counter = 1;

while (counter <= number)
{
    Console.WriteLine($"{counter}^2={Math.Pow(counter,2)}");
    counter++;
}