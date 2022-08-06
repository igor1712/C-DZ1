
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
void fun(int a)
{
    int summa = 0;
    int resault = 0;
    while(a > 0)
        {
            resault = a % 10;
            summa = summa + resault;
            a = a / 10;
        }
    Console.Write(summa);   
}
fun(a);