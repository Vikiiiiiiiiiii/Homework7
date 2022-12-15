//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

//получить числа с консоли 
int GetNumber(string message) 
{     
    int result = 0;      
    
    while(true)     
    {         
        Console.WriteLine(message);         
        if(int.TryParse(Console.ReadLine(), out result))         
        {             
            break;         
        }         
        else         
        {             
            Console.WriteLine("Ввели не число");         
        }     
    }      
    return result; 
}  

//задать двумерн. массив и заполнить его случайными веществен. числами 

void GetArray(double[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0); 
        }
    }
}
// печать
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
     
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите количество строк: "); 
int n = GetNumber("Введите количество столбцов: ");  
Console.WriteLine();
double[,] numbers = new double[m, n];
GetArray(numbers);
PrintArray(numbers);


