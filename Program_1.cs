Console.Clear();

int GetNumber (string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число или число меньше 1, введите любое положительное число: ";

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            if(result > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

int lengthLine = GetNumber("Введите кол-во строк: ");
int lengthColumn = GetNumber("Введите кол-во столбцов: ");
Random rnd = new Random();
int[,] numberArray = new int[lengthLine, lengthColumn];
int[] numberArraySort = new int[lengthColumn];

Console.WriteLine("Созданный массив:");

for (int m = 0; m < lengthLine; m++) 
{
    for (int n = 0; n < lengthColumn; n++)
    {
        numberArray[m, n] = rnd.Next(10, 100);
        Console.Write(numberArray[m, n] + ", ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Отсортированный массив по строкам:");

for (int m = 0; m < lengthLine; m++) 
{
    for (int n = 0; n < lengthColumn; n++)
    {
        numberArraySort[n] = numberArray[m, n];
    }

    Array.Sort(numberArraySort);

    for (int n = 0; n < lengthColumn; n++)
    {
       Console.Write(numberArraySort[n] + ", ");
    }

    Console.WriteLine();
}