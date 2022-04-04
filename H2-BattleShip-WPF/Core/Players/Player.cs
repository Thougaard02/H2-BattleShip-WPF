using H2_BattleShip_WPF.Core.Board;
using H2_BattleShip_WPF.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2_BattleShip_WPF.Core.Players
{
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public _2DBoard OwnBoard { get; set; }
        public _2DBoard EnemyBoard { get; set; }

        public Player(string name, _2DBoard ownBoard, _2DBoard enemyBoard)
        {
            this.Name = name;
            this.OwnBoard = ownBoard;
            this.EnemyBoard = enemyBoard;
        }
    }
}
