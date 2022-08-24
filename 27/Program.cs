
/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.*/

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

static int func(int m, int n, int sum)
        {
            if (m <= n)
            {
                sum = sum + m;
                m++;
                return func(m, n, sum);
            }
            return sum;
        }
Console.WriteLine(func(m,n,0));