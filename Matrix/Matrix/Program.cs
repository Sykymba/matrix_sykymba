using MyApp.Utilit;

class Program
{
    static void Main()
    {
        // запускаем бесконечный цикл 
        while (true)
        {
            // проверка исключений 
            try
            {
                // запрашиваем размер матрицы в int16 
                Console.Write("Введите размер матрицы 2, 3 (MAX: 3x3): ");
                int size = Int16.Parse(Console.ReadLine());
                
                // создаем пустые двухмерные матрицы 
                int[,] matrix_one = new int[size, size];
                int[,] matrix_two = new int[size, size];
                int[,] matrix_finish = new int[size, size];
                
                // наполняем матрицы 
                matrix_one = Creates.create(matrix_one, size);
                matrix_two = Creates.create(matrix_two, size);
                
                // выбор решения 
                Console.WriteLine("Выберите (+ , -): ");
                string option = Console.ReadLine();
                
                // запускаем решение и бесконечный цикл ( что бы не наполнять матрицы по 100 раз)
                while (true)
                {
                    try
                    {
                        switch (option)
                        {
                            case "+":
                                matrix_finish = Sum.sum(matrix_one, matrix_two, matrix_finish, size);
                                break;
                            case "-":
                                matrix_finish = Minus.minus(matrix_one, matrix_two, matrix_finish, size);
                                break;
                            case "x":
                                matrix_finish = Multiplication.Multiply(matrix_one, matrix_two, matrix_finish, size);
                                break;
                        }
                        //вывод ответа и завершение цикла
                        Info.info(matrix_finish, size);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("ОООУУУУ! 502");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOOO!!! 404");
            }
        }
    }
}