// // Задача 57:
// // Составить частотный словарь элементов
// // двумерного массива. Частотный словарь содержит
// // информацию о том, сколько раз встречается элемент
// // входных данных.


// int[,] CreatMatrixRandomInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write("{0}\t", matrix[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

// int[,] rndMatrix = CreatMatrixRandomInt(4, 4, 1, 9);
// PrintArray(rndMatrix);

// Console.WriteLine();

// int[] MatrixInArray(int[,] matrix)
// {
//     int k = 0;
//     int[] array = new int[matrix.Length];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; matrix.GetLength(1); j++)
//         {
//             array[k] = matrix[i, j];
//             k++;
//         }
//     }
//     return array;
// } 

// void PrintFrequencyDictionary(int[] array)
// {
//     int count = 1;
//     int currentNum = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         currentNum = array[i];
//         if (array[i] == currentNum)
//         {
//             count++;
//         }
//         else
//         {
//             Console.Write($"{currentNum}, -> {count}");
//             currentNum = array[i];
//             count = 1;
//         }

//     }
    
    
//     int[,] matrix = new int[,];
// }

// int[,] matrix = new int[4, 4];
// CreatMatrixRandomInt(matrix);
// PrintArray(matrix)

// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,4}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] PullMatrix(int[,] matrix)
{
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 15);
        }
    }
    return matrix;
}

int[] MatrixToArray(int[,] matrix)
{
    int k = 0;
    int[] array = new int[matrix.Length];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

// 1 1 5 5 6 6 9 9
void PrintFrequencyDictionary(int[] array)
{
    int count = 1;
    int currentNum = array[0];
    for(int i = 1; i<array.Length; i++)
    {
        if (array[i] == currentNum)
        {
            count++;
        } else
        {
            Console.WriteLine($"{currentNum} -> {count}");
            currentNum = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{currentNum} -> {count}");
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0,4}", array[i]);
    }
}

int[,] matrix = new int[4, 4];
PullMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
int[] arr = MatrixToArray(matrix);
Array.Sort(arr);
PrintArray(arr);
Console.WriteLine();
PrintFrequencyDictionary(arr);


