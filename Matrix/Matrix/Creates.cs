namespace MyApp.Utilit;

class Creates
{
	// наполнение матрицы
	public static int[,] create(int[,] matrix, int size)
	{
		for (int i = 0 ; i < size; i++)
		{
			Console.WriteLine($"Введите строку № {i + 1}");
			for (int j = 0; j < size; j++)
			{
				Console.Write($"     Число №{i + 1}: ");
				matrix[i, j] = int.Parse(Console.ReadLine());
			}
		}
		
		return matrix;
	}
}

