using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace XAML_tuto
{
    public class Unit
    {
        public Position position { get; }
        public int Id { get; }

        public Unit(int id, int beginc, int beginr)
        {
            position = new Position(beginc, beginr);
            Id = id;
        }

        public void Move(int row, int col)
        {
            position.Row = row; 
            position.Column = col;
        }
    }
}
