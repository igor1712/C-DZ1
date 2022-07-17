
Console.Write("Введите Пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
int num_left = 0 ;
int num_left_1 = 0 ;
int num_left_2 = 0 ;
int num_right = 0;
int num_right_1 = 0;
int num_right_2 = 0;
if(x > 9999 && x < 99999)
{
    num_left =  x / 1000;
    num_left_1 = num_left % 10; 
    num_left_2= num_left / 10;
    
    num_right = x % 100;
    num_right_1 = num_right / 10;
    num_right_2 = num_right % 10;
    
}
if(num_left_1 == num_right_1 & num_left_2 == num_right_2) 
{
    Console.Write("Это число является палиндромом.");
}
else
{
    Console.Write("Это число НЕ является палиндромом.");
}

