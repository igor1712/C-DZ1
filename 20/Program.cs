/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
либо значение элемента в двумерном массиве, и возвращает значение либо индекс 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:*/


System.Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение элемента: ");
int x = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[m,n];

void FillArray(int[,] matr) 

{
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,100);
      
           
        }    

    }                        
}

void PrintArray(int[,] matr)
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
bool isOK = false;
void Func(int[,] matr) 
{   
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i,j]==x) 
                {
                 isOK = true;
                 Console.WriteLine($"число {x} есть в  индексе: [{i}.{j}] ");    
                }                      
        }     
    }  
            if(!isOK) 
                {
                    Console.WriteLine("Такого значения нет в масиве. ");      
                }    

}

FillArray(matr);
Console.WriteLine();
Func(matr);
PrintArray(matr);
