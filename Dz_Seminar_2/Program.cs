// Домашнее задание № 2 к семинару 2.

// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int Cut(int arg)
{
    int n1 = arg / 10;
    int result = n1 % 10;
    return result;
}*

Console.Write("Write a three digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondNum =  Cut(number); 

Console.WriteLine($"The second digit of the number {number} is {secondNum}");
*/


// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Write("Input a number: ");
int numb = Convert.ToInt32(Console.ReadLine());

int Third(int arg)
{
while (arg > 999)
    arg = arg / 10;

if(arg > 99)
    arg = arg % 10;

else 
    arg = -1;
    return arg;
}
int result = Third(numb);

if (result == -1)
    Console.WriteLine("No third digit");
else
    Console.WriteLine(result);
*/


// Задача 15. // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


bool Weekend(int arg)
{
    if(arg < 6)
        return false;
    else 
        return true;
}

Console.Write("Enter the number indicating the day of the week (1 - 7): ");
int day = Convert.ToInt32(Console.ReadLine());

bool weekend = Weekend(day);

if(day<8)
{
if(weekend == true)
    Console.WriteLine("It's a day of rest");
else
    Console.WriteLine("It's a weekday");

}
else
    Console.WriteLine("Reread the terms");
