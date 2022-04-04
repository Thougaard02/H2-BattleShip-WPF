using H2_BattleShip_WPF.Core.Interfaces;
using H2_BattleShip_WPF.Core.Ships;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2_BattleShip_WPF.Core.Board
{
    public class _2DBoard : IBoard
    {
        const int COLUMNS = 10;
        const int ROWS = 10;
        public List<_2DShips> Ships { get; set; }
    }
}
