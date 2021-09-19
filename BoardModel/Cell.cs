using System;

namespace BoardModel
{
    public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool Occupied { get; set; }
        public bool Legalmoves { get; set; }

        public Cell(int x, int y)
        {
            Row = x;
            Column = y;
        }
    }
}
