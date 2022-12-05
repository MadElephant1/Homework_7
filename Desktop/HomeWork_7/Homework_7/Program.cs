// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*

void CreateRandom2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("Inter a number of rows: ");
int rowsVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inter a number of columns: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rowsVol, columnsVol];
CreateRandom2dArray(numbers);
Show2dArray(numbers);

*/

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*

void CreateRandom2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(-100, 100)) / 10;
        }
    }
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("Inter a number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inter a number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
CreateRandom2dArray(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}

Show2dArray(numbers);

*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void CreateRandom2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(-100, 100)) / 10;
        }
    }
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("Inter a number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inter a number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
CreateRandom2dArray(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
Show2dArray(numbers);