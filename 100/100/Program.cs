using System;
using System.Collections.Generic;

namespace _100 {
    class Program {

        public static int MinimumMoves (List < (int, int) > moves) {
            var movesCount = 0;
            MoveToNext (moves[0], moves[1], moves, ref movesCount, 0);
            return movesCount;
        }

        private static void MoveToNext ((int, int) position, (int, int) interim, List < (int, int) > moves, ref int movesCounter, int indexPosition) {
            indexPosition++;

            var positionX = position.Item1;
            var positionY = position.Item2;

            var interimX = interim.Item1;
            var interimY = interim.Item2;

            var xDelta = positionX - interimX;
            var yDelta = positionY - interimY;

            if (interim == moves[moves.Count - 1]) {
                return;
            }

            if ((uint) xDelta > 0 && (uint) yDelta > 0) {
                //diagonal move
                movesCounter++;
            } else {
                movesCounter++;
            }

            if (interim != moves[moves.Count - 1]) {
                MoveToNext (interim, moves[indexPosition], moves, ref movesCounter, indexPosition);
            }
            return;
        }

        static void Main (string[] args) {
            Console.WriteLine (Program.MinimumMoves (new List < (int, int) > {
                (0, 0),
                (1, 1),
                (1, 2),
                (1, 1),
                (0, 0)
            }));
        }
    }
}