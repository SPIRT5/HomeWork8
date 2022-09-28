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
int sumArray = 0;
int[] numberArraySort = new int[lengthLine];

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

for (int m = 0; m < lengthLine; m++) 
{
    sumArray = 0;
    for (int n = 0; n < lengthColumn; n++)
    {
        sumArray = sumArray + numberArray[m, n];
    }
    numberArraySort[m] = sumArray;
}

int minSum = numberArraySort[0];
int minIndex = 0;

for (int i = 1; i < numberArraySort.Length; i++)
{
    if (minSum > numberArraySort[i]) 
    {
        minSum = numberArraySort[i];
        minIndex = i;
    }
}

Console.WriteLine("Наименьшая сумма элементов: " + minSum + " в строке № " + (minIndex + 1));