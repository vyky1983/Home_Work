/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

int num;
Console.WriteLine("Enter your number:");
 num = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < num ; i ++)

{
    if(i % 2 == 0)

    Console.WriteLine("You number: {0} ", i);
}
