Console.Clear();
Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if(day == 6 ^ day == 7)
{
    Console.Write("Это выходной день ");
}
if(day > 7)
{
    Console.Write("В неделе ровно семь дней");
}
if(day<6 & day > 0)
{
    Console.Write("К сожалению рабочий день");
}
if(day == 0)
{
    Console.Write("Неделя начинается с первого дня , не с нуля.");
}
