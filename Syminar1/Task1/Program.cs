/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

int num, num1;
Console.WriteLine("Введите номер1 :");
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер2 :");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше максимальное число: " + Math.Max(num, num1));