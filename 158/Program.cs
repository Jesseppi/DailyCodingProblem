using System;
using System.Collections.Generic;

namespace _158
{
    class Program
    {
        public static List<List<(string, (int, int))>> CountTheNumberOfMovesFromTopLeftToBottomRight(int[][] matrix)
        {
            var wall = 1;

            var columns = matrix[0].Length;
            Console.WriteLine($"there are {columns} columns");

            var rows = matrix.Length;
            Console.WriteLine($"there are {rows} rows");

            var moves = new List<List<(string, (int, int))>>();
            var movesSoFar = new List<(string, (int, int))> { ("start", (0, 0)) };

            findAPath(matrix, wall, columns, rows, ref movesSoFar, ref moves);

            return moves;
        }

        private static void findAPath(int[][] matrix, int wall, int columns, int rows, ref List<(string, (int, int))> moveSoFar, ref List<List<(string, (int, int))>> moves)
        {

            var currentPosition = moveSoFar[moveSoFar.Count - 1];
            var currentRow = currentPosition.Item2.Item1;
            var currentColumn = currentPosition.Item2.Item2;

            if (currentRow == rows - 1 && currentColumn == columns - 1)
            {
                moves.Add(moveSoFar);
                moveSoFar = new  List<(string, (int, int))> { ("start", (0, 0)) };
            }

            // move right
            if (currentColumn + 1 <= columns - 1 && matrix[currentRow][currentColumn + 1] != wall)
            {
                moveSoFar.Add(("right", (currentRow, currentColumn + 1)));
                findAPath(matrix, wall, columns, rows, ref moveSoFar, ref moves);
            }

            if (currentRow + 1 <= rows - 1 && matrix[currentRow + 1][currentColumn] != wall)
            {
                moveSoFar.Add(("down", (currentRow + 1, currentColumn)));
                findAPath(matrix, wall, columns, rows, ref moveSoFar, ref moves);
            }

            return;
        }


        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[3] { 0, 0, 1 };
            array[1] = new int[3] { 0, 0, 1 };
            array[2] = new int[3] { 1, 0, 0 };

            var moves = Program.CountTheNumberOfMovesFromTopLeftToBottomRight(array);
            foreach (var path in moves)
            {
                Console.WriteLine("***********************************");
                Console.WriteLine("A possible path to the bottom right");
                foreach (var item in path)
                {
                    Console.WriteLine(item.Item1);
                }
                Console.WriteLine("***********************************");
                Console.WriteLine();
            }
        }
    }
}
