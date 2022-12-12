// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Clear();

int[,] NewMatrix(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i = i + 2)
    {
        for (int j = 1; j < array.GetLength(1); j = j + 2)
        {
            array [i,j] = array [i,j]*array [i,j];
        }
        Console.WriteLine();
    }
    return array;
}
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
int[,] newmatrix = NewMatrix(matrix);
Console.WriteLine();

ShowArray(newmatrix);




