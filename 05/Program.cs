Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a>999 ^ a<99)
{
    Console.Write("Это не трехзначное число.");
}
int num = a / 10 % 10;
Console.Write(num);
