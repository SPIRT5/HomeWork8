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
int[,] numberArray = new int[lengthLine, lengthColumn];
int numberArrayLength = lengthLine * lengthColumn;
int minLine = 0;
int minColumn = 0;
int maxLine = lengthLine;
int maxColumn = lengthColumn;
int rnd = 1;  //Заполнение массива
int i = 0;    //Шаг

Console.WriteLine("Созданный массив:");

while (rnd < (numberArrayLength + 1)) 
{
	while (i != maxColumn)  						// ход вправо
		{
			numberArray[minLine, i] = rnd;
			rnd++;
			i++;
		}
		minLine++; 
		i = minLine;

	while (i < (maxLine - 1)) 						// ход вниз
		{
			numberArray[i, (maxColumn - 1)] = rnd;
			rnd++;
			i++;
		}
		maxColumn--;
		i = maxColumn;

	while (i > (minColumn - 1) && minLine != maxLine) 	// ход влево
		{
			numberArray[(maxLine - 1), i] = rnd;
			rnd++;
			i--;
		}
		maxLine--;
		i = maxLine - 1;

	while (i > (minLine - 1) && minColumn != maxColumn)	// ход вверх
		{
			numberArray[i, minColumn] = rnd;
			rnd++;
			i--;
		}
		minColumn++;
		i = minColumn;
}



for (int m = 0; m < lengthLine; m++) 
{
    for (int n = 0; n < lengthColumn; n++)
    {
        Console.Write(numberArray[m, n] + ", ");
    }
    Console.WriteLine();
}
