/*Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих на нечётных 
позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int a = ReadInt ("Введите длину массива: ");
int [] numbers = new int [a];
int count = 0;
Console.Write("[ ");
for ( int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 10);
    Console.Write(numbers[i] + " ");
    if ( i % 2 != 0)
       {
        count = count + numbers[i];
       }
}
Console.Write("] ");
Console.Write("--> "+ count);
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}