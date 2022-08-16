/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

System.Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matr = new double[m,n];

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}   ");

        }
        Console.WriteLine();
    }

}

void FillArray(double[,] matr) 

{
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        
            matr[i, j] = new Random().Next(-100,1000)/10.0;
            if(matr[i,j]%1==0) matr[i,j]= matr[i,j]; 
                          
        }
    }
}
FillArray(matr);
PrintArray(matr);
