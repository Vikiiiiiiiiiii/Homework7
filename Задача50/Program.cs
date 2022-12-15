/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

// получение числа с консоли
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

// задаем массив 
void GetArray(int[,] array) 
{      
    Random rnd = new Random();      
    for (int i = 0; i < array.GetLength(0); i++)     
    {         
        for (int j = 0; j < array.GetLength(1); j++)         
        {             
            array[i, j] = rnd.Next(1, 10);         
        }     
    }      
 
}

// печать 
void PrintArray(int[,] array) 
{     
    for (int i = 0; i < array.GetLength(0); i++)     
    {         
        for (int j = 0; j < array.GetLength(1); j++)         
            {             
                Console.Write(array[i, j] + " ");         
            }         
            Console.WriteLine();     
    } 
} 

int[,] numbers = new int[6, 8]; // размерность
GetArray(numbers);
PrintArray(numbers);

int rows = GetNumber("Введите индекс строки: ");                       // позиция от 0
int columns = GetNumber("Введите индекс столбца: ");
    if (rows < numbers.GetLength(0) && columns < numbers.GetLength(1)) // нахождение элемента на позиции 
    {
       Console.WriteLine($"Выдано число: {numbers[rows, columns]}"); 
    }
    else Console.WriteLine($"{rows}{columns} -> такое число не существует");
 
