﻿/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

Console.WriteLine("Enter number A -> ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number B -> ");
int b = Convert.ToInt32(Console.ReadLine());
int k = a;

for (int i = 1; i < b; i++)
{
    k = k * a;
}
Console.WriteLine("A to the power of B is equal to -> " + k);