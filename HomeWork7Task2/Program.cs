// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 0, 0 -> 1

int ReadInt(string message)// функция чтения целого числа
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray2D(int rows, int columns, int min, int max) // функция создания двумерного массива
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(min, max + 1);
        }
    }
    return numbers;
}

void PrintArray2D(int[,] numbers) // функция вывода массива на экран
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}

int SearchElement(int[,] array, int indexRows, int indexColumns) // функция поиска элемента по заданным координатам
{
    int element = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == indexRows)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == indexColumns)
                {
                    element = array[i,j];
                    return element;
                }
            }
        }
    }return -1;
}

int[,] array = GenerateArray2D(3, 5, -10, 10);
PrintArray2D(array);
int indexRow = ReadInt("Введите индекс строки > ");
int indexColumn = ReadInt("Введите индекс столбца > ");
int searchElement = SearchElement(array, indexRow, indexColumn);

if (searchElement == -1) // условие, если координаты не входят в массив
{
    Console.WriteLine("В массиве нет числа с таким индексом");
}
else
{
    Console.WriteLine(searchElement);
}