﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите первое число:");
int numa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numb = int.Parse(Console.ReadLine());
if (numa > numb)
{
    Console.WriteLine("Первое число " + numa + " Больше, чем второе " + numb);
}
else
{
    Console.WriteLine("Второе число " + numb + " Больше, чем первое " + numa);
}
