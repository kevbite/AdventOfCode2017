using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AdventOfCode.Day3
{
    public class SpiralMemory
    {
        public int GetSteps(int square)
        {
            var numbers = Enumerable.Range(1, square);

            var centeredOctagonal = GetNextedCenteredOctagonal(square);

            var squareRoot = (int)Math.Sqrt(centeredOctagonal);

            var array = CreateArray(squareRoot);

return 0;
        }

        private object CreateArray(int size)
        {
            void Fill()
            {
                array[x, y] = count++;                
            }

            for (int i = 0; i < size * size; i++)
            {
                                
            }
            
            return null;
        }

        private int GetNextedCenteredOctagonal(int value)
        {
            var next = 0;

            for (int i = 1; value < next; i++)
            {
                next = (int)Math.Pow(2 * i - 1, 2);
            }
            
            return next;
        }
    }

    public class ArrayFiller
    {
        private int _x;
        private int _y;

        private Direction _direction;
        private Queue<Direction> directions;
        private int[,] _array;
        private int untilNextTurn;

        public ArrayFiller(int size)
        {
            _array = new int[size, size];

            var center = size / 2;

            _x = center;
            _y = center;

            _direction = Direction.East;
            directions = new Queue<Direction>(new []{Direction.North, Direction.West, Direction.South});
        }

        public void Move()
        {
            _directionMap[_direction](this);

            untilNextTurn--;

            if (untilNextTurn == 0)
            {
                directions.Enqueue(_direction);
                _direction = directions.Dequeue();
                //1, 1, 2, 2, 3, 3, 4, 4, 5
                
            }

        }

        public void Fill(int i)
        {
            _array[_x, _y] = i;
        }

        public void Fill()
        {
            
        }
        
        private readonly IReadOnlyDictionary<Direction, Action<ArrayFiller>> _directionMap = new Dictionary<Direction, Action<ArrayFiller>()
        {
            {Direction.East, (a) => a._x++},
            {Direction.North, (a) => a._y--},
            {Direction.West, (a) => a._x--},
            {Direction.South, (a) => a._y++},
        };
        
    }

    public enum Direction
    {
        North,
        East,
        South,
        West
    }
}