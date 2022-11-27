/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

double [] numbers = {4.5, 1.3, 2.8, 3.5};
double max = numbers[0];
double min = numbers[0];
int i = 0;
while (i < numbers.Length)
{
    if (numbers[i] > max)
    {
    max = numbers[i];
    }
    else if (numbers[i]< min)
    {
        min = numbers[i];
    }   
    i++;
}
double b = max - min;
Console.Write($"max = {max}; min = {min}; разница = {b} ");
