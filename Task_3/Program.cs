/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

int a = ReadInt ("Введите длину массива: ");
double [] numbers = new double [a];

Console.Write("[ ");
for ( int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 99);
    numbers[i] = (numbers[i])/10;
    Console.Write(numbers[i] + " ");
}

double max = numbers[0];
double min = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (max < numbers[i])
    {
        max = numbers[i];
    }
    if (min > numbers[i])
    {
        min = numbers[i];
    }
}
double b = max - min;
Console.Write("] -> ");
Console.Write($"max = {max}; min = {min}; разница = {b} ");
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}