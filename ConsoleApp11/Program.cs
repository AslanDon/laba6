Console.WriteLine("Vvedite dlinnu stroki:");
int stroka_size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite dlinnu stolbca:");
int stolbec_size = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[stroka_size, stolbec_size];

for(int i = 0; i < stroka_size; i++)
{
    for(int j = 0; j < stolbec_size; j++)
    {
        Console.WriteLine($"Vvedite element po indexu {i},{j}");
        matrix[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int i = 0; i < stroka_size; i++)
{
    for (int j = 0; j < stolbec_size; j++)
    {
        if (matrix[i,j] % 2 != 0)
        {
            Console.WriteLine(matrix[i,j]);
        }
    }
}

