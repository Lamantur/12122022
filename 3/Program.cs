//Задача 3.
//        Задайте двумерный массив из целых чисел. 
//        Найдите среднее арифметическое элементов в каждом столбце.




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


//Получаем отдельный столбец матрицы в виде массива
int[] GetColumn(int[,] matrix, int columN)
{
    int[] massiv = new int[matrix.GetLength(0)];
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = matrix[i, columN];
    }
    return massiv;
}


// Среднее арифметическое элементов массива
double Average(int[] massive)
{
    double average = 0;
    for (int i = 0; i < massive.Length; i++)
    {

        average = (double)(average + massive[i]) / massive.Length;
    }
    return average;
}

// Создание массива и заполнение средними арифметическими
double[] MassiveAverage(int m, int n)
{
    double[] massiv = new double[m];
    for (int i = 0; i < m; i++)
    {
        massiv[i] = (double)Average(GetColumn(GenerateMatrix(m, n), i));
    }
    return massiv;
}


//Ввод данных
int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}


//Печать массива
void PrintList(double[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        System.Console.Write(" " + list[i]);
    }
}

//Результат
PrintList(MassiveAverage(Prompt("Введите количество строк массива >"), Prompt("Введите количество столбцов массива >")));
// Не удалось применить Math.Round не понял как сдесь применить преобразование типа