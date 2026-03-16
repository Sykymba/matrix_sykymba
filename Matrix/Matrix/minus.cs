namespace MyApp.Utilit;

public class Minus
{
    //вычитание матриц
    public static int[,] minus(int[,] matrix_one, int[,] matrix_two, int[,] matrix_finish, int size)
    {
        // проходи по матрицам
        for (int row = 0; row < size; row++)
        {
            for (int coll = 0; coll < size; coll++)
            {
                matrix_finish[row, coll] = matrix_one[row, coll] - matrix_two[row, coll];
            }
        }
        //возвращаем результат
        return matrix_finish;
    }
}