namespace MyApp.Utilit;

public class Multiplication
{
    public static int[,] Multiply(int[,] matrix_one, int[,] matrix_two, int[,] matrix_finish, int size)
        {
            switch (size)
                {
                case 2:
                    int a = matrix_one[0, 0] * matrix_two[0, 0] + matrix_one[0, 1] * matrix_two[1, 0];
                    int c = matrix_one[0, 0] * matrix_two[1, 0] + matrix_one[0, 1] * matrix_two[1, 1];
                    int b = matrix_one[1, 0] * matrix_two[0, 0] + matrix_one[1, 1] * matrix_two[1, 0];
                    int d = matrix_one[1, 0] * matrix_two[0, 1] + matrix_one[1, 1] * matrix_two[1, 1];
                    
                    matrix_finish[0, 0] = a; matrix_finish[0, 1] = c; 
                    matrix_finish[1, 0] = b; matrix_finish[1, 1] = d;
                    break;
                case 3:
                    for (int i = 0; i < size; i++)
                    {
                        //a₁₁·b₁₁ + a₁₂·b₂₁ + a₁₃·b₃₁
                        int row_one_1 = matrix_one[i, 0] * matrix_two[0, 0] + matrix_one[i, 1] * 
                            matrix_two[1, 0] + matrix_one[i, 2] * matrix_two[2, 0];
                        //a₁₁·b₁₂ + a₁₂·b₂₂ + a₁₃·b₃₂
                        int row_one_2 = matrix_one[i, 0] * matrix_two[0, 1] + matrix_one[i, 1] * 
                            matrix_two[1, 1] + matrix_one[i, 2] * matrix_two[2, 1];
                        //a₁₁·b₁₃ + a₁₂·b₂₃ + a₁₃·b₃₃
                        int row_one_3 = matrix_one[i, 0] * matrix_two[0, 2] + matrix_one[i, 1] * 
                                matrix_two[1, 2] + matrix_one[i, 2] * matrix_two[2, 2];
                        matrix_finish[i, 0] = row_one_1; matrix_finish[i, 1] = row_one_2; 
                        matrix_finish[i, 2] = row_one_3;
                    }
                    break;
                }
            return matrix_finish;
        }
}