// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string message) // функция чтения целого числа
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] GenerateArray2D(int rows, int columns) // функция создания массива
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(1, 10);
        }
    }
    return numbers;
}

void PrintArray2D(int[,] numbers) // функция вывода на экран массива
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

double FindAvg(int[,] number) // функция вычисления среднего в каждом столбце
{
    double sum = 0;
    double avg = 0;   

    for (int j = 0; j < number.GetLength(1); j++)
    {
        sum = 0;
        avg = 0;
        for (int i = 0; i < number.GetLength(0);i++)
        {
            sum += number[i,j];
        }
        avg = sum / number.GetLength(0);
        System.Console.WriteLine($"Среднее арифметическое столбца № {j+1}: {avg:f2}");
    }
    return avg; 
}

int rows = ReadInt("введите количество строк: ");
int columns = ReadInt("введите количество столбцов: ");
int[,] newArray = GenerateArray2D(rows,columns);
PrintArray2D(newArray);
System.Console.WriteLine();
double output = FindAvg(newArray);

