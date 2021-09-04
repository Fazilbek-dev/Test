using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] _el = new string[4, 9] { 
                { "-", "*", "-", "-", "-", "-", "-", "-", "-"},
                { "*", "-", "-", "-", "*", "-", "*", "-", "-"},
                { "-", "*", "-", "-", "*", "*", "*", "-", "*"},
                { "*", "*", "-", "*", "*", "*", "*", "-", "-"} };

            int rows = _el.GetUpperBound(0) + 1;
            int columns = _el.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{_el[i, j]} ");
                    if (j == 8)
                    {
                        Console.WriteLine("\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\t \t \t");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    switch (i)
                    {
                        case 0:
                            _el[0, 0] = "-";
                            _el[0, 1] = "-";
                            _el[0, 2] = "-";
                            _el[0, 3] = "-";
                            _el[0, 4] = "*";
                            _el[0, 5] = "-";
                            _el[0, 6] = "-";
                            _el[0, 7] = "-";
                            _el[0, 8] = "-";
                            break;
                        case 1:
                            _el[1, 0] = "-";
                            _el[1, 1] = "-";
                            _el[1, 2] = "-";
                            _el[1, 3] = "*";
                            _el[1, 4] = "*";
                            _el[1, 5] = "*";
                            _el[1, 6] = "-";
                            _el[1, 7] = "-";
                            _el[1, 8] = "-";
                            break;
                        case 2:
                            _el[2, 0] = "-";
                            _el[2, 1] = "-";
                            _el[2, 2] = "*";
                            _el[2, 3] = "*";
                            _el[2, 4] = "*";
                            _el[2, 5] = "*";
                            _el[2, 6] = "*";
                            _el[2, 7] = "-";
                            _el[2, 8] = "-";
                            break;
                        case 3:
                            _el[3, 0] = "-";
                            _el[3, 1] = "*";
                            _el[3, 2] = "*";
                            _el[3, 3] = "*";
                            _el[3, 4] = "*";
                            _el[3, 5] = "*";
                            _el[3, 6] = "*";
                            _el[3, 7] = "*";
                            _el[3, 8] = "-";
                            break;
                    }
                    Console.Write($"{_el[i, j]} ");
                    if(j == 8)
                    {
                        Console.WriteLine("\t");
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
