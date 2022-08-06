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

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/

Console.Write("Введите длину масива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int resault = 0;
int count = 0;
int max = 0;
int min = 20 ;
for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(1,20);
while(count<array.Length)
    {
        if(max<array[count]) max=array[count];
        if(min>array[count]) min=array[count];
        count++;
    }  
resault = max - min;
P_Aray(array);
Console.WriteLine();
Console.WriteLine("Максимальное число в масиве: "+max);
Console.WriteLine("Минимальное число в масиве: "+min);
Console.WriteLine("Разница между максимальным и минимальным элементов массива. : " + resault);