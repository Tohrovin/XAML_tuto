using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace XAML_tuto
{
    public class Game
    {
        public MapGrid map { get; }
        private Unit currentUnit { get; }
        public Position checkedPos { get; }
        public Game()
        {
            map = new MapGrid(10, 10);
            currentUnit = new Unit(1, 1, 1);
            checkedPos = new Position(1, 1);
        }

        private void MoveUnit(int row, int col)
        {
            map[currentUnit.position.Row, currentUnit.position.Column] = 0;
            map[row, col] = currentUnit.Id;
            currentUnit.Move(row, col);
        }

        public void CheckTile(int row, int col)
        {
            checkedPos.Column = col;
            checkedPos.Row = row;
        }
    }
}
