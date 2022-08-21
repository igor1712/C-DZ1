

/*Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:*/

System.Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[m,n];


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

void Find(int[,] array) 
{  
  int i = 0;
  int num = 1 ;
    for (int j = 0; j <= n-1; j++)
        {
        array[i,j] += num;
        num ++; 
        } 
    for ( i = 1; i <= m-1; i++)
        {
            int j = 3 ;
            array[i,j] += num;
            num++;
        }                
    for (int j = 2; j >= 0; j--)
        {
            i = 3 ;
            array[i,j] += num;
            num++;
        }   
    for ( i = 2; i >= 1; i--)
        {
           int j = 0 ;
            array[i,j] += num;
            num++;
        }
    for (int j = 1; j <= m-2; j++)
        {
            i = 1 ;
            array[i,j] += num;
            num++;
        }
    for (int j = 2; j >= 1; j--)
        {
            i = 2 ;
            array[i,j] += num;
            num++;
        }

}

Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Find(array);
PrintArray(array);


