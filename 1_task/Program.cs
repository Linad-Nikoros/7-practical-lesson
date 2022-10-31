// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Введите количество строк: ");
int number1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int number2 =Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int [number1,number2];

for(int i=0;i<array1.GetLength(0);i++)
{
for(int j=0;j<array1.GetLength(1);j++)
{
array1[i,j]=new Random().Next(0,1000);    
Console.Write(array1[i,j]+" ");
}
Console.WriteLine();
}