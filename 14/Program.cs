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

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
Console.Write("Введите длину масива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int resault = 0;
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,999);  
    if(array[i] % 2 == 0) resault += 1; 
}

P_Aray(array);
Console.WriteLine();
Console.WriteLine("Колличество четных чисел в масиве: " + resault);