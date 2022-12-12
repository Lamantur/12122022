//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//Генерация матрицы случайных чисел типа double размера m X n с указанием диапазона 
double[,] GenerateMatrix(int m, int n, int minRange, int maxRange)
{

    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((((new Random().NextDouble()) * (maxRange - minRange)) + minRange), 3);
        }
    }
    return matrix;
}

//Ввод данных
int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

//Печать матрицы
void PrintArrayTwo(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine("");
    }
}

PrintArrayTwo(GenerateMatrix(Prompt("Введите m"), Prompt("Введите n"), -100, 100));