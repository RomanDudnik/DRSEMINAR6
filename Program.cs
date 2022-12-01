//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
//

int PositiveNumbersInput(int A)
{
    int size = A;
    int current = 0;
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input your number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        current += 1;
    }
    return current;
}

Console.WriteLine("Input how many numbers you will enter: ");
int amount = Convert.ToInt32(Console.ReadLine());
int positiveNums = PositiveNumbersInput(amount);

Console.WriteLine($"The amount of numbers you entered greater than 0 is {positiveNums} ");




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
// Запросить у пользователя коэфициенты (k1, k2, k3, k4)

