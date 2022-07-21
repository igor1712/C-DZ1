Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int resault;
while(num >= count)
{
    resault = count * count * count;
    count++;
    Console.Write(resault + " ");
}
