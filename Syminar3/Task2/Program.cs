/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double getDistance(int[] pointA, int[] pointB)
{
    int a = pointA[0] - pointB[0];
    int b = pointA[1] - pointB[1];
    int c = pointA[2] - pointB[2];

    double result = Math.Sqrt(a * a + b * b + c * c);
    return result;
}


int[] pointA = new int[3];
int[] pointB = new int[3];


Console.WriteLine("Enter x1 coordinate:");
pointA[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter y1 coordinate:");
pointA[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter z1 coordinate:");
pointA[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter x2 coordinate:");
pointB[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter y2 coordinate:");
pointB[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter z2 coordinate:");
pointB[2] = Convert.ToInt32(Console.ReadLine());

double result = getDistance(pointA, pointB);

Console.WriteLine(Math.Round(result, 2));
