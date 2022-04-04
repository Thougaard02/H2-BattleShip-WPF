using H2_BattleShip_WPF.Core.Coordinate;
using H2_BattleShip_WPF.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2_BattleShip_WPF.Core.Ships
{
    public class _2DShips : _2DCoordinate, IShip
    {
        public string Name { get; set; }
        public int Lenght { get; set; }
        public bool IsAlive { get; set; }
        public List<_2DCoordinate> Coordinates { get; set; }
    }
}
