// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] InitArray( int layer, int rows, int columns)
{ 
    Random rnd = new Random();
    int[,,] newArray = new int[layer, rows, columns];
    for(int i = 0; i < layer; i++) 
    { 
        for(int j = 0; j < rows; j++) 
        { 
            for(int k = 0; k < columns; k++) 
            { 
            newArray[i,j,k] = rnd.Next(10,100); 
            } 
        } 
    }
    return newArray; 
} 
void PrintArray(int[,,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for(int j = 0; j < array.GetLength(1); j++) 
        { 
            for(int k = 0; k < array.GetLength(2); k++) 
            { 
            Console.Write($" {array[i, j, k]}" + " " + "[" + i + "," + j + "," + k + "]" ); 
            } 
        Console.WriteLine(); 
        } 
    Console.WriteLine(); 
    } 
Console.WriteLine(); 
} 
                    
Console.Write("Введите количество слоев: "); 
// запросили количество полей 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите количество строк: "); 
// запросили длину строки 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите количество столбцов: "); 
// запросили количество столбцов 
int l = Convert.ToInt32(Console.ReadLine()); 
int[,,] array = InitArray(m, n, l); 
PrintArray(array);