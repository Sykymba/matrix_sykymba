namespace MyApp.Utilit;

public class Sum
{
    //сложение матриц
    public static int[,] sum(int[,] matrix_one, int[,] matrix_two, int[,] matrix_finish, int size)
    {
        // проходим по матрицам
        for (int row = 0; row < size; row++)
        {
            for (int coll = 0; coll < size; coll++)
            {
                matrix_finish[row, coll] = matrix_one[row, coll] + matrix_two[row, coll];
                
            }
        }
        return matrix_finish;
    }
}