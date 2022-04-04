using System;
using System.Collections.Generic;
using System.Text;
using H2_BattleShip_WPF.Core.Coordinate;

namespace H2_BattleShip_WPF.Core.Ships
{
    public class Cruiser : _2DShips 
    {
        public Cruiser(string name, List<_2DCoordinate> coordinates) : base (name, coordinates)
        {
            
        }
    }
}
