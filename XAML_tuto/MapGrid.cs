using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAML_tuto
{
    public class MapGrid
    {
        public readonly int[,] grid;
        public int Rows { get; }
        public int Columns { get; }

        public int this[int row, int col]
        {
            get => grid[row, col];
            set => grid[row, col] = value;
        }

        public MapGrid(int rows, int columns)
        {
            Columns = columns;
            Rows = rows;
            grid = new int[rows, columns];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    grid[i, j] = 0;
                }
            }

        }

        public bool IsUnit(int row, int col)
        {
            return grid[row, col] == 0;
        }

        public bool IsInside(int row, int col)
        {
            return row >= 0 && row < Rows && col >= 0 && col < Columns; //to się chyba nie przyda ale ciii
        }

        public bool IsEmpty(int row, int col)
        {
            return IsInside(row, col) && grid[row, col] == 0;
        }
    }
}
