﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
int num, num1, num2;
Console.WriteLine("Введите трехзначное число: ");
num = Convert.ToInt32(Console.ReadLine());
num1 = num / 10;
num2 = num1 % 10;
Console.WriteLine(num2);