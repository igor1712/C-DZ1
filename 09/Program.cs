/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/


Console.Write("Введите точку А1: ");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку A2: ");
double a2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку А3: ");
double a3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите точку B1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку B2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку B3: ");
double b3 = Convert.ToDouble(Console.ReadLine());

double resault;

resault = Math.Sqrt(Math.Pow((b1-a1),2) + Math.Pow((b2-a2),2) + Math.Pow((b3-a3),2));
Console.Write(Math.Round(resault, 2));

 