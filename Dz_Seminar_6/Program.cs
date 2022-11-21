// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

/*
int AmountMore(int amount)
{ 
    int i = 1;  
    int count = 0;
    while(i <= amount)
    {
        Console.Write("Input a number: ");
        int a = Convert.ToInt32(Console.ReadLine());
            if(a>0)
               count++;
        i++;
    }
    return count;
}

Console.Write("How many digits do you want to enter: ");
int amount = Convert.ToInt32(Console.ReadLine());

int a = AmountMore(amount);

Console.WriteLine($"More than zero {a} digits");
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionLines(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k2 * b1 - k1 * b2)/(k2 - k1);
    
    if(k1==k2 && b1==b2) 
        Console.WriteLine("The given lines coincide!");
    else if(k1==k2)
        Console.WriteLine("The given lines do not intersect!");
    else
        Console.WriteLine($"Point of intersection of given lines: ({x}; {y})");
}


Console.Write("Input the b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionLines(b1, k1, b2, k2);