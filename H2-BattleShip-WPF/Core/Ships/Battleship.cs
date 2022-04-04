using System;
using System.Collections.Generic;
using System.Text;
using H2_BattleShip_WPF.Core.Coordinate;

namespace H2_BattleShip_WPF.Core.Ships
{
    public class Battleship : _2DShips
    {
        public Battleship(string name, List<_2DCoordinate> coordinates) : base(name, coordinates)
        {

        }
    }
}
