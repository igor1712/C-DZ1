Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int num ;
if(a < 99)
{
    Console.Write("Это не трехзначное число.");
}
if(a > 99 & a < 999 )
{
    num = a % 10;
    Console.WriteLine(num);
} 
if(a > 999 & a < 9999)
{
    num = a / 10 % 10;
    Console.WriteLine(num);
}
if(a > 9999)
{
    num = a / 100 % 10;
    Console.WriteLine(num);
}