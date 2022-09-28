Console.Clear();

int lengthX = 2;
int lengthY = 2;
int lengthZ = 2;
Random rnd = new Random();
int[,,] numberArray = new int[lengthX, lengthY, lengthZ];

Console.WriteLine("Созданный массив:");

for (int x = 0; x < lengthX; x++) 
{
    for (int y = 0; y < lengthY; y++)
    {
        for (int z = 0; z < lengthZ; z++) 
        {
            numberArray[x, y, z] = rnd.Next(10, 100);
            Console.Write(numberArray[x, y, z]  + "(" + x + "," + y +"," + z + "); ");
        } 
    }
}

Console.WriteLine();