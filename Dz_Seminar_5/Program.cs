int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
       array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
         Console.Write(array[i] + " ");

    Console.WriteLine();
}


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


/*
int FindEvenNumder(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count += 1;
    return count;   
}

int min = 100;
int max = 999;

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

int findEvenNumder = FindEvenNumder(myArray);

Console.WriteLine("The number of even elements in the array is " + findEvenNumder);
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

/*
int FindOddPositions(int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i=i+2)
        sum += array[i];
    return sum;   
}

int min = -99;
int max = 99;

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

int oddPositions = FindOddPositions(myArray);

Console.WriteLine("The sum of the elements in odd positions is " + oddPositions);
*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double[] CreateDoubleRandomArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = minValue + (new Random().NextDouble()) * (maxValue - minValue);
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}
void PrintDoubleArray(double[] array)
{
    Console.Write("The created array is: ");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
double DiffBetweenMaxMinItems(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < min) min = array[i];
    Console.Write($"The min element in this array is {min}\n");
    for (int i = 1; i < array.Length; i++)
        if (array[i] > max) max = array[i];
    Console.Write($"The max element in this array is {max}\n");
    return Math.Round(max - min, 2);
}
Console.Write("Input the size of the array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the value of the min element in the array: ");
double min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the value of the max element in the array: ");
double max = Convert.ToInt32(Console.ReadLine());
double[] myDoubleArray = CreateDoubleRandomArray(sizeArray, min, max);
PrintDoubleArray(myDoubleArray);
Console.Write($"The difference between the max and min elements is {DiffBetweenMaxMinItems(myDoubleArray)}");