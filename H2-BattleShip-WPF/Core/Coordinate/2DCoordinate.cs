using H2_BattleShip_WPF.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2_BattleShip_WPF.Core.Coordinate
{
    public class _2DCoordinate : ICoordinate
    {
        public bool IsHit { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
