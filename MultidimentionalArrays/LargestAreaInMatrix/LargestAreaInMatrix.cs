﻿namespace LargestAreaInMatrix
{
    using System;
    using System.Collections.Generic;

    class Neighbour
    {
        public Neighbour(short row, short col, short content)
        {
            this.Row = row;
            this.Col = col;
            this.Content = content;
        }

        public short Row { get; set; }

        public short Col { get; set; }

        public short Content { get; set; }
    }

    class LargestArea
    {
        private const sbyte Visited = sbyte.MinValue;

        static void Main(string[] args)
        {
            var matrix = FillMatrix();
            var largestArea = CalculateLargestArea(matrix);
            Console.WriteLine(largestArea);
        }

        private static int CalculateLargestArea(short[,] matrix)
        {
            int largestArea = 0;

            for (short row = 0; row < matrix.GetLength(0); row++)
            {
                for (short col = 0; col < matrix.GetLength(1); col++)
                {
                    var neighbour = new Neighbour(row, col, matrix[row, col]);
                    var currentMax = 0;
                    var queue = new Queue<Neighbour>();
                    queue.Enqueue(neighbour);

                    while (queue.Count > 0)
                    {
                        var current = queue.Dequeue();
                        matrix[current.Row, current.Col] = Visited;
                        var neighbours = GetNeighbours(matrix, current);
                        currentMax++;

                        foreach (var item in neighbours)
                        {
                            if (item.Content != Visited)
                            {
                                queue.Enqueue(item);
                            }
                        }
                    }

                    if (currentMax > largestArea)
                    {
                        largestArea = currentMax;
                    }
                }
            }

            return largestArea;
        }

        private static List<Neighbour> GetNeighbours(short[,] matrix, Neighbour neighbour)
        {
            var list = new List<Neighbour>();

            if (InBounds(neighbour.Row + 1, neighbour.Col, matrix) && matrix[neighbour.Row + 1, neighbour.Col] == neighbour.Content)
            {
                list.Add(new Neighbour((short)(neighbour.Row + 1), neighbour.Col, matrix[neighbour.Row + 1, neighbour.Col]));
                matrix[neighbour.Row + 1, neighbour.Col] = Visited;
            }
            if (InBounds(neighbour.Row - 1, neighbour.Col, matrix) && matrix[neighbour.Row - 1, neighbour.Col] == neighbour.Content)
            {
                list.Add(new Neighbour((short)(neighbour.Row - 1), neighbour.Col, matrix[neighbour.Row - 1, neighbour.Col]));
                matrix[neighbour.Row - 1, neighbour.Col] = Visited;
            }
            if (InBounds(neighbour.Row, neighbour.Col + 1, matrix) && matrix[neighbour.Row, neighbour.Col + 1] == neighbour.Content)
            {
                list.Add(new Neighbour(neighbour.Row, (short)(neighbour.Col + 1), matrix[neighbour.Row, neighbour.Col + 1]));
                matrix[neighbour.Row, neighbour.Col + 1] = Visited;
            }
            if (InBounds(neighbour.Row, neighbour.Col - 1, matrix) && matrix[neighbour.Row, neighbour.Col - 1] == neighbour.Content)
            {
                list.Add(new Neighbour(neighbour.Row, (short)(neighbour.Col - 1), matrix[neighbour.Row, neighbour.Col - 1]));
                matrix[neighbour.Row, neighbour.Col - 1] = Visited;
            }

            return list;
        }

        private static bool InBounds(int row, int col, short[,] matrix)
        {
            if (row >= 0 && row < (short)matrix.GetLength(0) && col >= 0 && col < (short)matrix.GetLength(1) && matrix[row, col] != Visited)
            {
                return true;
            }

            return false;
        }

        private static short[,] FillMatrix()
        {
            var dimensions = Console.ReadLine().Split(' ');
            var rows = short.Parse(dimensions[0]);
            var cols = short.Parse(dimensions[1]);
            var matrix = new short[rows, cols];

            for (short row = 0; row < rows; row++)
            {
                var line = Console.ReadLine().Split(' ');

                for (short col = 0; col < cols; col++)
                {
                    matrix[row, col] = short.Parse(line[col]);
                }
            }

            return matrix;
        }
    }
}