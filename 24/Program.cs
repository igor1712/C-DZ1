

/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/


System.Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array1 = new int[m,n];

int[,] array2 = new int[m,n];

int[,] res = new int[m,n];

void PrintArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i, j]}   ");

        }
        Console.WriteLine();
    }

}

void FillArray(int[,] array1) 
{

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {

            array1[i, j] = new Random().Next(1,10);

        }
    }
}

void Find(int[,] res) 
{

    for (int i = 0; i <= res.GetLength(0) - 1; i++)
    {
        for (int j = 0; j <= res.GetLength(1) - 1; j++)
        {
            res[i,j] = array1[i,j] * array2[i,j];
        }
    }
}

FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FillArray(array2);

PrintArray(array2);
Console.WriteLine();
Find(res);

PrintArray(res);