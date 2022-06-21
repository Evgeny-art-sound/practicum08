// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
Console.Clear();
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
    }
}
void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(1, 100);
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[rows, columns];
int rows1 = rows - 1;
int columns1 = columns - 1;
int[,] newArray = new int[rows1, columns1];
FillArray(array);
Console.WriteLine("Заполненный массив: ");
PrintArray(array);
int indexRowsMin = -0;
int indexColumnsMin = 0;
int min = array[0, 0];
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        if (array[i, j] < min)
        {
            min = array[i, j];
            indexRowsMin = i;
            indexColumnsMin = j;
        }
Console.WriteLine();
Console.WriteLine($"Минимальное число в массиве: {array[indexRowsMin, indexColumnsMin]}");
Console.WriteLine($"Расположено в строке: {indexRowsMin + 1} ,столбце: {indexColumnsMin + 1}");

int rowsNewArray = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int columnsNewArray = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j != indexColumnsMin)
        {
            newArray[rowsNewArray, columnsNewArray] = array[i, j];
            columnsNewArray++;
        }
    }
    if (i != indexRowsMin)
        rowsNewArray++;
}
Console.WriteLine("Удалим строку истолбец с минимальным элементом ");
Console.WriteLine("Покажем сокращенный массив: ");
PrintArray(newArray);