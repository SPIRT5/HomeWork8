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
int[,] numberFisrtArray = new int[lengthLine, lengthColumn];
int[,] numberSecondArray = new int[lengthLine, lengthColumn];
int[,] numberResultArray = new int[lengthLine, lengthColumn];

Console.WriteLine("Созданный первый массив:");

for (int m = 0; m < lengthLine; m++) 
{
    for (int n = 0; n < lengthColumn; n++)
    {
        numberFisrtArray[m, n] = rnd.Next(10, 100);
        Console.Write(numberFisrtArray[m, n] + ", ");
    }
    Console.WriteLine();
}

Console.WriteLine("Созданный второй массив:");

for (int m = 0; m < lengthLine; m++) 
{
    for (int n = 0; n < lengthColumn; n++)
    {
        numberSecondArray[m, n] = rnd.Next(10, 100);
        Console.Write(numberSecondArray[m, n] + ", ");
    }
    Console.WriteLine();
}

Console.WriteLine("Массив произведений:");

for (int m = 0; m < lengthLine; m++) 
{
    for (int n = 0; n < lengthColumn; n++)
    {
        numberResultArray[m, n] = numberFisrtArray[m, n] * numberSecondArray[m, n];
        Console.Write(numberResultArray[m, n] + ", ");
    }
    Console.WriteLine();
}