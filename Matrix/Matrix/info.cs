namespace MyApp.Utilit;

class Info
{
    public static void info(int[,] matrix,int size)
    {
        // вывод матрицы 
        for (int row = 0; row < size; row++)
        {
            for (int coll = 0; coll < size; coll++)
            {
                Console.Write($"{matrix[row, coll]} ");
            }
            Console.WriteLine();
        }
    }
}