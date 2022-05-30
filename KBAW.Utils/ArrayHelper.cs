using System;
using System.Linq;
using KBAW.ErrorHandler;

namespace KBAW.Utils
{
    public static class ArrayHelper
    {
        public static int[] FindIndex(this Array array, object element)
        {
            if (array.Rank == 1)
            {
                int index = Array.IndexOf(array, element);

                if (index != -1)
                {
                    return new[] { index };
                }

                throw new CustomApplicationException("Element not found");
            }

            var found = array.OfType<object>()
                .Select((v, i) => new { v, i })
                .FirstOrDefault(s => s.v.Equals(element));

            if (found == null)
            {
                throw new CustomApplicationException("Element not found");
            }

            int[] indexes = new int[array.Rank];
            int last = found.i;
            int lastLength = Enumerable.Range(0, array.Rank)
                .Aggregate(1,
                    (a, v) => a * array.GetLength(v));

            for (int rank = 0; rank < array.Rank; rank++)
            {
                lastLength /= array.GetLength(rank);
                int value = last / lastLength;
                last -= value * lastLength;

                int index = value + array.GetLowerBound(rank);

                if (index > array.GetUpperBound(rank))
                {
                    throw new IndexOutOfRangeException();
                }

                indexes[rank] = index;
            }

            return indexes;
        }

        public static int[] GetRow(this int[,] array, int rowNumber = 0)
        {
            return Enumerable.Range(0, array.GetLength(1))
                .Select(x => array[rowNumber, x])
                .ToArray();
        }

        public static int[] GetColumn(this int[,] array, int columnNumber = 0)
        {
            return Enumerable.Range(0, array.GetLength(0))
                .Select(x => array[x, columnNumber])
                .ToArray();
        }
    }
}