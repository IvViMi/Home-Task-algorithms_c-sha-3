﻿/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Clear();
Console.WriteLine("Сотавление таблицы кубов целого числа");
Console.WriteLine("Введите целое число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Число" + "\t" + "Куб");
int i = 0;
for (i = 1; i <= n; i++)
{
    Console.WriteLine(i + "\t" + i * i * i);
}
