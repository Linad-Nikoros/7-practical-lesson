// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[5, 5];

void fill_array()
{
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        array1[i, j] = new Random().Next(0, 100);
    }
}
}

void pint_array()
{
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        Console.Write(array1[i, j] + " ");
    }
    Console.WriteLine();
}
}

fill_array();
pint_array();
if (rows > array1.GetLength(0) || columns > array1.GetLength(0) || rows<=0 || columns<=0) Console.WriteLine ("Число отсутствует");
else
{
    int output_num = array1[rows - 1, columns - 1];
    Console.Write(output_num);
}
