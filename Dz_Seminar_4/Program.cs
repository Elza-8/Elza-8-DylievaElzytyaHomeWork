// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
/*

int Exponentiate(int a, int b)
{
    int degree = a;
    if(b == 0)
    {
        degree = 1;
    }
    for(int current = 1; current < b; current ++)
    degree = degree * a; 
    return degree;
}

Console.Write("Input a number a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number {a} raised to the power of a number {b} is equal to {Exponentiate(a, b)}");
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int SumDigit(int number)
{ 
    int sum = 0;  
   
    while (number != 0)
    {
        sum = number % 10 + sum;
        number = number / 10;
    }
    return sum;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of the numbers in {num} is {SumDigit(num)}");



// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input the number with the index {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("\nThe created array is: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.Write("Input number of array elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
PrintArray(myArray);
*/