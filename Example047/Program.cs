// Программа, которая задаёт двумерный массив размером m x n, 
// заполненный случайными вещественными числами

double[,] CreateArray(int rows, int columns)
{
    var random = new Random();
    double[,] array = new double[rows, columns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 200) + random.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);
            if (j != input.GetLength(1) - 1) Console.Write(", ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите значение m: ");
var m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение n: ");
var n = int.Parse(Console.ReadLine()!);
var array = CreateArray(m, n);
PrintArray(array);