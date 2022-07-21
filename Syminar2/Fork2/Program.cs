Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
string num1 = Convert.ToString(num);

if(num1.Length > 2)
{
    Console.Write("Третья цифра -> " + num1[2]);
}
else
{
    Console.Write(" -> третьей цифры нет ");
}

