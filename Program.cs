//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
//

/*
double PositiveNumbersOutput(double A)
{
    double size = A;
    double current = 0;
    for (double i = 0; i < size; i++)
    {
        Console.Write("Input your number: ");
        double num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        current += 1;
    }
    return current;
}

Console.WriteLine("Input how many numbers you will enter: ");
double amount = Convert.ToInt32(Console.ReadLine());
if (amount < 0)
    amount *= -1;                                      // на случай введения отрицательного числа
double positiveNums = PositiveNumbersOutput(amount);
Console.WriteLine($"The amount of numbers you entered greater than 0 is {positiveNums} ");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// y = k1*x + b1
// y = k2*x + b2 <-----------------                 
//                                |
// k1*x + b1 = k2*x + b2          |
// k1*x - k2*x = b2 - b1          |
// x (k1 - k2) = b2 - b1 => x_____  (в программе будет только x)

// k1 and k2 если они равны, то линии паралельны (соотв. точки пересечения нет)
// Запросить у пользователя коэфициенты (k1, k2, b1, b2)

/*
void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double xPoint=0;
    double yPoint=0;
    if (b1 == b2 && k1 == k2) 
        Console.WriteLine("Straight lines match");
    else 
        if (k1 == k2) 
            Console.WriteLine("The lines are parallel to each other");
        else 
        {
            xPoint = (b2-b1) / (k1-k2);
            yPoint = k1 * xPoint + b1;
            Console.WriteLine($"Сrossing point  ({xPoint} ; {yPoint})");
        }
}

Console.WriteLine("Input the first point x: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the first point y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the second point x: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the second point y: ");
double y2 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint(x1, y1, x2, y2);
*/