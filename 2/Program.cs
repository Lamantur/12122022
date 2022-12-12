//  Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

//Генерация матрицы случайных чисел типа int размера m X n
int[,] GenerateMatrix(int m, int n)
{

    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
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

//Получаем отдельную строку матрицы
int[] GetString(int[,] matrix, int stringN)
{
    int[] massiv = new int[matrix.GetLength(1)];
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = matrix[stringN, i];
    }
    return massiv;
}


int m = Prompt("сгенерировать матрицу из количества строк > ");
int n = Prompt("сгенерировать матрицу из количества столбцов > ");
int strm = Prompt("Ряд >");
int coln = Prompt("Стролбец");
if (strm <= m && coln <= n)
{
    System.Console.WriteLine(GetString(GenerateMatrix(m, n), strm - 1)[coln - 1]);
}
else { System.Console.WriteLine("такого числа в массиве нет"); }
