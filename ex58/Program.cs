// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("введите размеры матриц:");
int m = InputNumbers("введите число строк 1-й матрицы: ");
int n = InputNumbers("введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("введите число столбцов 2-й матрицы: ");
int range = InputNumbers("введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
GetArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMartrix);

int[,] secondMartrix = new int[n, p];
GetArray(secondMartrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMartrix);

int[,] resultMatrix = new int[m,p];
MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);

// метод находения произведения двух матриц.
void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
// ввод диапазона
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
// метод создания двумерного массива
void GetArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}
// метод для вывода массива на экран
void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

