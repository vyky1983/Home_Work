/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int num, num1, num2, res;
Console.WriteLine("Enter 3 number:");
num = Convert.ToInt32(Console.ReadLine());
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
res = Math.Max(num, num1);

//Console.WriteLine("Ваше максимальное число: {0} ", res);
if(res > num2)
{
    Console.WriteLine("Max: {0} " , res);
}
else
{
 Console.WriteLine("Max: {0} " , num2);
}   
