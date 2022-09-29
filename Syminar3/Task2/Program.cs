/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

using static System.Console;
Clear();

Write("Введите координаты х1: ");
double a1 = Convert.ToInt32(ReadLine());
Write("Введите координаты х2: ");
double a2 = Convert.ToInt32(ReadLine());
Write("Введите координаты x3: ");
double a3 = Convert.ToInt32(ReadLine());

Write("Введите координаты y1: ");
double b1 = Convert.ToInt32(ReadLine());
Write("Введите координаты y2: ");
double b2 = Convert.ToInt32(ReadLine());
Write("Введите координаты y3: ");
double b3 = Convert.ToInt32(ReadLine());

double lenght = Math.Sqrt(Math.Pow(a1 - b1,2) + Math.Pow(a2 - b2,2)+Math.Pow(a3-b3,2));
WriteLine($"{lenght:f2}");