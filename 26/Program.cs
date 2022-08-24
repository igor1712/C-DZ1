
/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.*/

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Find(int m,int n)
{
     if (m>=n)
     {
        return m;
     } 
   Console.WriteLine(m);
   return Find(m+1,n);  

   
}
Console.WriteLine(Find(m,n));