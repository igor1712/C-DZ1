void P_Array(int[] matr)
{  
    int count = matr.Length;
    int pos = 0;
    while(pos<count)
    {
        Console.Write($"{matr[pos]},");
        pos++;

    }
}

System.Console.WriteLine("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] matr = new int[m];
void FillArray(int[] matr) 
{
    
    for (int i = 0; i < matr.Length; i++)
    {
        
        matr[i] = new Random().Next(-5,20);
            
    }
}


/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, -567, 89, 223-> 3*/


void Func(int m) 
{
    int res = 0;
    for (int i = 0; i < matr.Length; i++)
    {
       if(matr[i]>0) res = res +1;
       
    }
    Console.WriteLine("Сумма элементов больше  нуля: "+ res);
}


FillArray(matr);

P_Array(matr);
Console.WriteLine();
Func(m);