using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Counter
    {
        public int CountBiggestIsland( int [,] arr)
        {
            var totalColumns = arr.GetLength(1);
            var totalrows = arr.GetLength(0);
            var neighbors = new List<int>();
            for (int currentColumnIndex = 0; currentColumnIndex < totalColumns; currentColumnIndex++)
            {
                for (int currentRowIndex = 0; currentRowIndex < totalrows; currentRowIndex++)
                {
                    if (arr[currentColumnIndex,currentRowIndex]==1)
                    {
                        neighbors.Add(LookForNeighbors(arr,currentColumnIndex,currentRowIndex,totalrows,totalColumns));
                    }
                }
            }

            return neighbors.Max();
        }

        public int LookForNeighbors(int[,] arr, int currentColumnIndex, int currentRowIndex, int totalrows, int totalColumns)
        {
            int numberOfNeighbors = 0;

            for (int i = 0; i < totalrows; i++)
            {
                if (arr[i,currentColumnIndex]==1)
                {
                    numberOfNeighbors++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < totalrows; i++)
            {
                if (arr[currentRowIndex, i] == 1)
                {
                    numberOfNeighbors++;
                }
                else
                {
                    break;
                }
            }

            return numberOfNeighbors;
        }
    }
}
