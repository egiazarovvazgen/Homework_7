// Программа, которая задаёт двумерный массив из целых чисел 
// и находит среднее арифметическое элементов в каждом столбце

Console.WriteLine("Введите значение m: ");
var m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение n: ");
var n = int.Parse(Console.ReadLine()!);
var array = CreateArray(m, n);
PrintArray(array);
Average(array);

int[,] CreateArray(int rows, int columns)
{
    var random = new Random();
    int[,] array = new int[rows, columns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 200);
        }
    }
    return array;
}

void PrintArray(int[,] input)
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

int Average(int[,] input)
{
    var average = 0;
    for (var i = 0; i < input.GetLength(1); i++)
    {
        for (var j = 0; j < input.GetLength(0); j++)
        {
            average += input[j, i];
        }
        Console.WriteLine($"Cреднее арифметическое элементов в столбце №{i + 1} = {(float)average / m}");
    }
    return average;
}