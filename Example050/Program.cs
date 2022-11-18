// Программа, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет

Console.WriteLine("Введите значение m: ");
var m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение n: ");
var n = int.Parse(Console.ReadLine()!);
var array = CreateArray(m, n);
PrintArray(array);
GetPositionOfElement(array);

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

void GetPositionOfElement(int[,] input)
{
    Console.WriteLine("Введите значение элемента a: ");
    var a = int.Parse(Console.ReadLine()!);
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            if (input[i, j].Equals(a))
            {
                Console.WriteLine("Позиция этого элемента: " + (i, j));
                return;
            }
        }
    }
    Console.WriteLine("Такого элемента нет");
}