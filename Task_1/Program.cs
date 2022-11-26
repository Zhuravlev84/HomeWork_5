/*Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int a = ReadInt ("Введите длину массива: ");
int [] numbers = new int [a];
int count = 0;
Console.Write("[ ");
for ( int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(100, 1000);
    Console.Write(numbers[i] + " ");
    if (numbers[i] % 2 == 0)
       {
        count++;
       }
}
Console.Write("] ");
Console.Write("--> "+ count);
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}