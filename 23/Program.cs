

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/

System.Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matr = new int[m,n];
int[] arr = new int[m];


void FillArray(int[,] matr) 
{   
    for (int i = 0; i < matr.GetLength(0); i++) 
        for (int j = 0; j <matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(10,30);

        }       
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}    ");
        }
        Console.WriteLine();
    }
}
void Find(int[,] matr,int[] Arr) 
{   
    
    for (int i = 0; i <= m-1; i++)      // счетчик строк от индекса 0 
        {     
               
            for (int j = 0; j < n; j++) // счетчик столбцов от индекса 0
                {     
                    arr[i] +=  matr[i,j];   // в масиве храниться сумма каждой строки   
                } 

        }            
         Console.WriteLine();               
} 
void PrintArray_1(int[] arr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        
            Console.Write($"{arr[i]}    ");
        
        Console.WriteLine();
    }
}


FillArray(matr);
PrintArray(matr);
Console.WriteLine();
Find(matr,arr);
//PrintArray_1(arr);
Console.WriteLine();

void minArr(int[] arr)
{
    for (int i = 0; i <= arr.Length-1;)
    {
        int min = 0;
        
        for (int j = i; j < arr.Length-1; j++)
        {
            if(arr[i]>arr[j] )
            {
                arr[min] = arr[j];
                min = j;
            }
        } 
        Console.WriteLine($"минимальная сумма {arr[min]} находитсья в строке: {(min)+1}");  
    break;
    }
} 

minArr(arr);   

