﻿// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i <=n; i++)
{
    if ( i % 2 == 0)
    Console.Write($"{i * i * i} ");
}