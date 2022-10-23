// Домашнее задание № 3 к семинару 3.

// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// РЕШЕНИЕ № 1 ТОЛЬКО ДЛЯ ПЯТИЗНАЧНОГО ЧИСЛА.
/*
void Palindrome(int argument)
{
    if(argument / 100000 == 0 && argument / 10000 > 0)
        {
            if(argument/10000 == argument % 10)
                 if((argument/1000)%10 == (argument % 100)/10)
                     Console.WriteLine("Number is a palindromenumber");
                 else Console.WriteLine("Number is not a palindromenumber");
            else Console.WriteLine("Number is not a palindromenumber");
        }
else Console.WriteLine("Error! you did not enter a five-digit number! Reread the condition!");
}

Console.Write("Enter a five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

Palindrome(num);
*/

// РЕШЕНИЕ № 2 УНИВЕРСАЛЬНОЕ, ЧЕРЕЗ ЦИКЛ
/*
int NumberCounter(int amount)
{   
    int result = 0;
    while(amount > 0)
    {
        amount = amount / 10;
        result++;
    }
    if(result != 1) 
       return result;
    else
       return -1;
}

Console.Write("Enter a number greater than 10: ");
int num = Convert.ToInt32(Console.ReadLine());
int numerator = (NumberCounter(num));
double enumeratorType = Convert.ToDouble(numerator);
int des = Convert.ToInt32(Math.Pow(10, enumeratorType));

bool Palindrome2(int argument, int del)
{
    int des2 = 10;
    int des3 = 1;
    int start = 0;
    int finish = 0;

    while(des>des2)
       {
        start = (argument % (des) / (des/10));
        finish = ((argument % des2)/des3);
        {
            if(start == finish)
            {
               des = des / 10;
               des2 = des2 * 10;
               des3 = des3 * 10;
            }
            else 
               return false;
        }
       }
    return true;
       
}

bool result =  Palindrome2(num, des);

if(numerator != -1)
{
    if(result == true)
    
       Console.WriteLine("It's a palindrome");
    else
       Console.WriteLine("It's not a palindrome");
}
else
    Console.WriteLine("Reread the terms");
*/

// РЕШЕНИЕ № 3 ПЕРЕВЕРТЫШ ЧЕРЕЗ ЦИКЛ
/*
bool PalindromeRevers3(int number)
{
    int revers = 0;
    int temporary = 0;

    while (number > 0)
    {
        temporary = number % 10;
        revers = revers * 10 + temporary;
        number = number / 10;
    }
    if(number == revers)
        return true;
    else 
        return false;
}

int NumberCounter(int amount)
{   
    int result = 0;
    while(amount > 0)
    {  
        amount = amount / 10;
        result++;
    }
    return result; 
}

Console.Write("Enter a number greater than 10: ");
int numb = Convert.ToInt32(Console.ReadLine());

bool numberRevers = PalindromeRevers3(numb);
int count = NumberCounter(numb);

if(count > 1)
{
if(numberRevers == true)
    Console.WriteLine("It's a palindrome");
else
    Console.WriteLine("It's not a palindrome");

}
else
    Console.WriteLine("Reread the terms");
*/


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double resPointX = x1 - x2;
    double resPointY = y1 - y2;
    double resPointZ = z1 - z2;
    double result = Math.Sqrt(resPointX * resPointX + resPointY * resPointY + resPointZ * resPointZ);
    return result;
}
Console.WriteLine("Enter the coordinates x1: ");
double pointX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates x2: ");
double pointX2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates y1: ");
double pointY = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates y2: ");
double pointY2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates z1: ");
double pointZ = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates z2: ");
double pointZ2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Answer: {Distance(pointX, pointX2, pointY, pointY2, pointZ, pointZ2)}");
*/



// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void Table(int number)
{
    int index = 1;
    while (index <= number)
    {
        double result = Math.Pow(index,3);
        Console.Write(result + " ");
        index++;
    }
}
Console.Write("Введите число: ");
int res = Convert.ToInt32(Console.ReadLine());
Table(res);