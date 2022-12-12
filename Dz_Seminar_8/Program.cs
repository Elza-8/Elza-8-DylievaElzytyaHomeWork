int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}


void Show2dArray(int[,] array, string msg="Generated array:\n")
{
    Console.WriteLine(msg);

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();  
}


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
void NewOrder(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)  
            for (int k = j + 1; k < array.GetLength(1); k++)
                if (array[i, j] < array[i, k])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k ] = temp;
                    }
        
    
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);


NewOrder(myArray);
Show2dArray(myArray);
*/


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int[] SumLine(int[,] array)
{
    int[] sumA = new int[array.GetLength(0)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
    int sum =  0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            sumA[i] = sum;
        }
    }
    return sumA;
}

int MinLine(int[] array)
{   
    int min = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[min] > array[i])
            min = i;
    return min;
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);


int[] SumLin = SumLine(myArray);
int MinLin = MinLine(SumLin);

Console.WriteLine($"Amount with minimum line number {MinLin}");
*/


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    if (matrix1.GetLength(0) == matrix2.GetLength(1))
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix2.GetLength(1); j++)
                for (int k = 0; k < matrix2.GetLength(0); k++)
                    resultMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
    }
    return resultMatrix;
}
Console.WriteLine("Enter parameters of the first matrix:");
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter parameters of the second matrix:");
Console.Write("Enter a number of rows: ");
Console.Write("Input a number of rows: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max2 = Convert.ToInt32(Console.ReadLine());


int[,] firstMatrix = CreateRandom2dArray(m, n, min, max);
Show2dArray(firstMatrix, "First matrix:");
int[,] secondMatrix = CreateRandom2dArray(m2, n2, min2, max2);
Show2dArray(secondMatrix, "Second matrix:");
int[,] resultMatrix = MatrixProduct(firstMatrix, secondMatrix);
Show2dArray(resultMatrix, "Result matrix:");
*/


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
int[] GetUniqueArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(minValue, maxValue);
        if (i != 0)
        {
            for (int j = 0; j < i; j++)
                while (array[j] == array[i])
                {
                    array[i] = rand.Next(minValue, maxValue + 1);
                    j = 0;
                }
        }
    }
    return array;
}
int[,,] GetUnique3DArray(int xSize=2, int ySize=2, int zSize=2, int minValue=10, int maxValue=99)
{
    int[,,] array = new int[xSize, ySize, zSize];
    int[] baseArray = GetUniqueArray(xSize * ySize * zSize, minValue, maxValue);
    int baseIndex = 0;
    for (int i = 0; i < xSize; i++)
        for (int j = 0; j < ySize; j++)
            for (int k = 0; k < zSize; k++)
            {
                array[i, j, k] = baseArray[baseIndex];
                baseIndex++;
            }
    return array;
}
void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string output = string.Empty;
            for (int k = 0; k < array.GetLength(2); k++)
                output += $"{array[i, j, k]}({i},{j},{k}) ";
            Console.WriteLine(output);
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Enter three dimensions of the array (x * y * z <= 90)");
Console.Write("Enter x dimension of the array: ");
int arrX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y dimension of the array: ");
int arrY = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter z dimension of the array: ");
int arrZ = Convert.ToInt32(Console.ReadLine());
int[,,] rand3DArr = GetUnique3DArray(arrX, arrY, arrZ);
Show3DArray(rand3DArr);
*/


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*
void SnailFillArray(int[,] array)
{
    int iStart = 0, iEnd = 0, jStart = 0, jEnd = 0;

    int i = 0;
    int j = 0;

    for (int k = 0; k < array.Length; k++)
    {
        array[i, j] = k + 1;
        if (i == iStart && j < array.GetLength(1) - jEnd - 1)
            j++;
        else if (j == array.GetLength(1) - jEnd - 1 && i < array.GetLength(0) - iEnd - 1)
            i++;
        else if (i == array.GetLength(0) - iEnd - 1 && j > jStart)
            j--;
        else
            i--;

        if ((i == iStart + 1) && (j == jStart) && (jStart != array.GetLength(1) - jEnd - 1)){
            iStart++;
            iEnd++;
            jStart++;
            jEnd++;
        }
    }
}

Console.Write("Enter a number of rows: ");
int snailRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns: ");
int snailCols = Convert.ToInt32(Console.ReadLine());
int[,] snailArr = new int[snailRows, snailCols];
Show2DArray(snailArr);
SnailFillArray(snailArr);
Show2DArray(snailArr, "Filled array:");
*/