// Домашнее задание № 1 к семинару 1.

// Задача № 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/* 
 Console.Write("Input a first number: ");
 int number1 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Input a second number: ");
 int number2 = Convert.ToInt32(Console.ReadLine());

 if(number1 > number2)
 {
    Console.WriteLine($"Number {number1} is a greater, number {number2} is a less");
 }
 else
 {
    Console.WriteLine($"Number {number2} is a greater, number {number1} is a less");
 }
*/

 //Задача № 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/* 
  Console.Write("Input a first number: ");
 int number1 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Input a second number: ");
 int number2 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Input a third number: ");
 int number3 = Convert.ToInt32(Console.ReadLine());

 int max = number1;

 
 if( number2 > max ) max = number2;
 if( number3 > max ) max = number3;

 Console.Write("max = ");
 Console.WriteLine(max);
*/

//Задача № 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
 Console.Write("Input a number: ");
 int number = Convert.ToInt32(Console.ReadLine());
 
 int remainder = number % 2;
 
 if(remainder > 0)
 {
    Console.WriteLine($"Number {number} is odd");
 }
 else
 {
    Console.WriteLine($"Number {number} is even");
 } 
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
 
Console.WriteLine("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current <= N)
{
    if (current % 2 == 0)
        Console.Write(current + " ");
    current = current + 2;
}

 