// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] InitArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MultiplicationArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    int sum = 0;
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            sum = firstArray[i, j] * secondArray[i, j];
            resultArray[i, j] = sum;
        }
    }
}

Console.WriteLine("Введите количество строк первой матрицы");
int rowFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы");
int columnFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите количество строк первой матрицы");
int rowSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы");
int columnSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] firstArray = new int[rowFirst, columnFirst];
InitArray(firstArray);
Console.WriteLine("Первая матрица");
PrintArray(firstArray);
Console.WriteLine();

int[,] secondArray = new int[rowSecond, columnSecond];
InitArray(secondArray);
Console.WriteLine("Вторая матрица");
PrintArray(secondArray);

int[,] resultArray = new int[rowFirst, columnSecond];
MultiplicationArray(firstArray,secondArray,resultArray);
Console.WriteLine();
Console.WriteLine("Результат");
PrintArray(resultArray);