using H2_BattleShip_WPF.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2_BattleShip_WPF.Core.Coordinate
{
    public class _2DCoordinate : ICoordinate
    {
        public bool IsHit { get; set; } = false;
        public int X { get; set; }
        public int Y { get; set; }

        public _2DCoordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
