
/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/


System.Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matr = new int[m,n];

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
void Find(int[,] matr) 
{   
    
    for (int i = 0; i <= m-1; i++)      // счетчик строк от индекса 0 
        {
            for (int j = 0; j < n; j++) // счетчик столбцов от индекса 0
            {
                
                for (int q = j; q < n; q++)      // счетчик столбцов от индекса j
                {  
                    if(matr[i,j]>matr[i,q])      // сравниваем нулевой индекс с  первым 
                    {
                        int min = j;             // переменная для хранения минимального индекса строки
                        int temp = matr[i,min];  // создал переменную для хранения начального результата индекса min
                        matr[i,min] = matr[i,q]; // минимальный индекс в позиции q  присваеваем в переменную мин
                        matr[i,q] = temp;        // поменял местами начальный результат с индексом q
                    }   
                } 

            }    
               
        }  
        Console.WriteLine();
        PrintArray(matr);         
}    
FillArray(matr);
PrintArray(matr);
Console.WriteLine();
Find(matr);
