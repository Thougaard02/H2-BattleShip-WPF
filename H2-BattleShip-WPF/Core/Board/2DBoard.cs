using H2_BattleShip_WPF.Core.Interfaces;
using H2_BattleShip_WPF.Core.Ships;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2_BattleShip_WPF.Core.Board
{
    public class _2DBoard : IBoard
    {
        public const int COLUMNS = 10;
        public const int ROWS = 10;
        public List<_2DShips> Ships { get; set; }

        public _2DBoard()
        {
            Ships = new List<_2DShips>();
        }

        public void GreatGrid()
        {
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {

                }
            }
        }
    }
}
