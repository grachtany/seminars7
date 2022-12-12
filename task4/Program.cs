
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
Console.Clear();
void ShowArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] CreateRandomArray(int rows, int coluns, int LeftRange, int RightRange)
{
    int[,] array = new int[rows, coluns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coluns; j++)
        {
            array[i, j] = new Random().Next(LeftRange, RightRange);

        }
    }
    return array;
}

int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
// Получить от пользователя m b n

int m = EnterNumber("Введите значение m: ");

int n = EnterNumber("Введите значение n: ");

// Создать двумерный массив
int[,] matrix = CreateRandomArray(m, n, 2, 10);


// ВЫвести массив
ShowArray(matrix);
// Поменять в массиве 

Console.WriteLine();
int i = 0;
int sum = 0;
while ((i < m) && (i < n))
{
    m = matrix[i, i];
    sum = sum+m;
    i++;
}
Console.WriteLine("Сумма диагональных элементов - " + sum);