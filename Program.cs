/*Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Console.Write ("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] GetArray (int m, int n)
{
    double [,] array = new double [m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return array;
}
double [,] result = GetArray (rows, columns);

void PrintArray (double [,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write (inputArray [i, j] + " ");
        }
        Console.WriteLine ();
    }
}
PrintArray (result);


Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)

Console.Write ("Введите номер строки:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца:");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [3,4];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}

Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Write ("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[rows, columns];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(0); j++)
{
    double average = 0;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        average += numbers[i,j];
    }
    average = average / rows;
    Console.Write(average + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
