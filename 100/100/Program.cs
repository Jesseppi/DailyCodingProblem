using System;
using System.Collections.Generic;

namespace _100 {
    class Program {

        public int MinimumMoves (List<Tuple<int, int>> moves) {

        }

        private int MovesToNext (Tuple<int, int> position, Tuple<int, int> destination) {
            // figure out which way im moving
            positionX = position.Item1;
            positionY = position.Item2;

            destinationX = destination.Item1;
            destinationY = destination.Item2;

            //moving left
            if (positionX > destinationX) {

            }
            //moving down
            if (positionY > destinationY) {

            }
            // moving right
            if (positionX < destinationX) {

            }
            // Moving up
            if (positionY > destinationY) {

            }

            //
        }

        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
        }
    }
}