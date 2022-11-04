// Задача 52.  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] array1 = new int[5, 7
];

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

int sum = 0;
int average = 0;
for (int i = 0; i < array1.GetLength(1); i++)
{
    sum=0;
    for (int j = 0; j < array1.GetLength(0); j++)
    {
        sum = sum+ array1[j, i];
        average = sum / array1.GetLength(0);
        
    }
Console.WriteLine($"Среднее арифметическое {i+1} столбца равно : {average}");
}
