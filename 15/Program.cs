
void P_Aray(int[] col)
{  
    int count = col.Length;
    int pos = 0;
    while(pos<count)
    {
        Console.Write($"{col[pos]},");
        pos++;

    }
}

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/

Console.Write("Введите длину масива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int resault = 0;
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,20);    
}
while(count<array.Length)
    {
        resault += array[count];
        count+=2;
    }
P_Aray(array);
Console.WriteLine();
Console.WriteLine("Сумму элементов, стоящих на нечётных позициях. : " + resault);