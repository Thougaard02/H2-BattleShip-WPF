using H2_BattleShip_WPF.Core.Coordinate;
using H2_BattleShip_WPF.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2_BattleShip_WPF.Core.Ships
{
    public class _2DShips : IShip
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public bool IsAlive { get; set; } = true;
        public List<_2DCoordinate> Coordinates { get; set; }

        public _2DShips(string name, List<_2DCoordinate> coordinates)
        {
            this.Name = name;
            this.Coordinates = coordinates;
            this.Length = coordinates.Count;
        }
    }
}
