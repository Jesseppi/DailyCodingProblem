using System;
using System.Collections.Generic;

namespace boardSearcher {
    class Program {

        bool exists (List<List<char>> board, string word) {
            for (var row = 0; row <= board.Count - 1; row++) {
                for (int column = 0; column < board[row].Count; column++) {
                    var visited = new List<Tuple<int, int>> ();
                    if (searchBoard (board, row, column, word, 0, visited)) return true;;
                }
            }
            return false;
        }

        bool searchBoard (List<List<char>> board, int row, int column, string word, int matchIndex, List<Tuple<int, int>> visited) {
            Console.WriteLine ("Im looking for an " + word[matchIndex]);
            if (!isValid (board, row, column)) {
                return false;
            } else if (visited.Contains (Tuple.Create (row, column))) {
                Console.WriteLine ("I HAVE BEEN HERE BEFORE");
                return false;
            } else if (board[row][column] != word[matchIndex]) {
                Console.WriteLine ("This Cell does not match");
                return false;
            } else if (matchIndex == word.Length - 1) {
                return true;
            }

            matchIndex++;
            visited.Add (Tuple.Create (row, column));

            var adjacentCells = new List<Tuple<int, int>> { Tuple.Create (0, -1), Tuple.Create (0, 1), Tuple.Create (-1, 0), Tuple.Create (1, 0) };
            foreach (var cell in adjacentCells) {
                if (searchBoard (board, row+cell.Item1, column + cell.Item2, word, matchIndex, visited)) {
                    return true;
                }
            }

            visited.Remove (Tuple.Create (row, column));

            return false;
        }

        bool isValid (List<List<char>> board, int row, int column) {
            Console.WriteLine ("Valid Check ************");
            Console.WriteLine ("row: " + row);
            Console.WriteLine ("column: " + column);
            if (row < 0 || column < 0) return false;
            if (row > board.Count) return false;
            if (column > board[row].Count) return false;
            Console.WriteLine ("im valid");
            Console.WriteLine ("Valid Check ************");
            return true;
        }

        static void Main (string[] args) {

            var board = new List<List<char>> {
                new List<char> { 'A', 'B', 'C', 'D' },
                new List<char> { 'S', 'F', 'C', 'S' },
                new List<char> { 'A', 'D', 'E', 'E' }
            };
            var program = new Program ();
            Console.WriteLine (program.exists (board, "SEE"));
        }
    }
}