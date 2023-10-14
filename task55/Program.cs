// // Задача 55:
// // Задайте двумерный массив. Напишите программу,
// // которая заменяет строки на столбцы. В случае, если это
// // невозможно, программа должна вывести сообщение для
// // пользователя.

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
        
//     }

//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
    
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($" {matrix[i, j], 6}");
//         }
//         Console.WriteLine("    |");
//     }
   
// }


// void ReplaseRowColumt(int [,] matrix)
// {
//     int row = matrix.GetLength(0);
//     int column = matrix.GetLength(1);
//     if (row != column)
//     {
//         Console.WriteLine("no");
//     }
//     else
//     {      
//         for (int i = 0; i < matrix.GetLength(0)-1; i++)
//         {
//             for (int j = i + 1; j < matrix.GetLength(1); j++)
//             {
//                 int temp = matrix[i, j];
//                 matrix[i, j] = matrix[j, i];
//                 matrix[j, i] = temp;
//             }
//         }
//     }
// }

// int[,] array2d = CreateMatrixRndInt(6, 5, -10, 10);
// PrintMatrix(array2d);
// ReplaseRowColumt(array2d);
// Console.WriteLine();
// PrintMatrix(array2d);



int[,] CreatMatrixRandomInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0}\t", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

//     0 1 2 3         0 1 2 3

// 0   1 2 3 4     0   1 1 1 1
// 1   1 2 3 4     1   2 2 2 2
// 2   1 2 3 4     2   3 3 3 3
// 3   1 2 3 4     3   4 4 4 4
// 1,0
// 2,0
// 2,1
// 3,0
// 3,1
// 3,2

void ReplaceRowsWithColomns(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

int[,] rndMatrix = CreatMatrixRandomInt(4, 4, 1, 9);
PrintArray(rndMatrix);

Console.WriteLine();
if (rndMatrix.GetLength(0) != rndMatrix.GetLength(1))
{
    Console.WriteLine("Невозможно заменить строки на столюцы!");
    return;
}
ReplaceRowsWithColomns(rndMatrix);
PrintArray(rndMatrix);