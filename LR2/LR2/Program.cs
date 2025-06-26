// 1_1
//Console.Write("Введіть розмірність масиву: ");
//int n = int.Parse(Console.ReadLine());

//int[] array = new int[n];

//Console.WriteLine("Введіть елементи масиву:");
//for (int i = 0; i < n; i++)
//{
//    Console.Write($"Елемент {i + 1}: ");
//    array[i] = int.Parse(Console.ReadLine());
//}

//Console.Write("Введіть число для перевірки кратності: ");
//int k = int.Parse(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
//    if (array[i] < 0 && array[i] % k == 0)
//    {
//        array[i] = -array[i];
//    }
//}

//Console.WriteLine("Оброблений масив:");
//for (int i = 0; i < n; i++)
//{
//    Console.Write(array[i] + " ");
//}
//Console.WriteLine();
//Console.ReadKey();



// 1_2
//Console.Write("Введіть розмірність масиву (кількість рядків): ");
//int rows = int.Parse(Console.ReadLine());
//Console.Write("Введіть розмірність масиву (кількість стовпців): ");
//int cols = int.Parse(Console.ReadLine());

//int[,] array = new int[rows, cols];

//Console.WriteLine("Введіть елементи масиву:");
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        Console.Write($"Елемент [{i + 1},{j + 1}]: ");
//        array[i, j] = int.Parse(Console.ReadLine());
//    }
//}

//Console.Write("Введіть число для перевірки кратності: ");
//int k = int.Parse(Console.ReadLine());

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        if (array[i, j] < 0 && array[i, j] % k == 0)
//        {
//            array[i, j] = -array[i, j]; 
//        }
//    }
//}

//Console.WriteLine("Оброблений масив:");
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < cols; j++)
//    {
//        Console.Write(array[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

//Console.ReadKey();



// 2
//Console.Write("Введіть розмір масиву: ");
//int n = int.Parse(Console.ReadLine());

//double[] arr = new double[n];

//Console.WriteLine("Введіть елементи масиву:");
//for (int i = 0; i < n; i++)
//{
//    Console.Write($"arr[{i}] = ");
//    arr[i] = double.Parse(Console.ReadLine());
//}

//double min = arr[0];
//for (int i = 1; i < n; i++)
//{
//    if (arr[i] < min)
//    {
//        min = arr[i];
//    }
//}

//for (int i = 0; i < n; i++)
//{
//    if (arr[i] == min)
//    {
//        arr[i] = -arr[i];
//    }
//}

//Console.WriteLine("Масив після заміни мінімальних елементів:");
//for (int i = 0; i < n; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//Console.ReadKey();


// 3
//Console.Write("Введіть розмірність матриці n: ");
//int n = int.Parse(Console.ReadLine());

//int[,] matrix = new int[n, n];

//Console.WriteLine("Введіть елементи матриці:");
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write($"matrix[{i},{j}] = ");
//        matrix[i, j] = int.Parse(Console.ReadLine());
//    }
//}

//Console.WriteLine("\nВведена матриця:");
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//int sum = 0;
//int count = 0;

//for (int i = 0; i < n; i++)
//{
//    int j = n - i - 1;
//    if (matrix[i, j] != 0)
//    {
//        sum += matrix[i, j];
//        count++;
//    }
//}

//double average = (double)sum / count;
//Console.WriteLine($"Середнє арифметичне: {average}");

//Console.ReadKey();


// 4
Console.Write("Введіть кількість рядків у масиві: ");
int n = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[n][];

for (int i = 0; i < n; i++)
{
    Console.Write($"Введіть кількість елементів у рядку {i + 1}: ");
    int m = int.Parse(Console.ReadLine());
    jaggedArray[i] = new int[m];

    Console.WriteLine($"Введіть елементи для рядка {i + 1}: ");
    for (int j = 0; j < m; j++)
    {
        Console.Write($"Element[{i + 1},{j + 1}] = ");
        jaggedArray[i][j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\nСхідчастий масив:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + "\t"); 
    }
    Console.WriteLine();
}

int maxColumns = 0;
foreach (var row in jaggedArray)
{
    if (row.Length > maxColumns)
        maxColumns = row.Length;
}

int[] negativeSums = new int[maxColumns];

for (int j = 0; j < maxColumns; j++)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        if (j < jaggedArray[i].Length && jaggedArray[i][j] < 0)
        {
            sum += jaggedArray[i][j];
        }
    }
    negativeSums[j] = sum;
}

Console.WriteLine("\nСума від'ємних елементів для кожного стовпця:");
for (int j = 0; j < negativeSums.Length; j++)
{
    Console.WriteLine($"Стовпець {j + 1}: {negativeSums[j]}");
}
Console.ReadKey();