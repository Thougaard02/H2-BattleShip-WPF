using H2_BattleShip_WPF.Core.Players;
using System;
using System.Collections.Generic;
using System.Text;
using H2_BattleShip_WPF.Core.Board;
using H2_BattleShip_WPF.Core.Coordinate;
using H2_BattleShip_WPF.Core.Ships;

namespace H2_BattleShip_WPF.Core.Manager
{
    public class GameManager
    {
        public List<Player> Players { get; set; }

        public GameManager()
        {
            Players = new List<Player>();
            var playerBoard = new _2DBoard();

            playerBoard = this.AddTestShip(playerBoard);

            var enemyBoard = new _2DBoard();
            Players.Add(new Player("Player1", playerBoard, enemyBoard));
        }

        private _2DBoard AddTestShip(_2DBoard playerBoard)
        {
            var coordinatesForShip1 = new List<_2DCoordinate>() { new _2DCoordinate(1, 2), new _2DCoordinate(2, 12), new _2DCoordinate(3,2) };
            var ship = new _2DShips("ship1", coordinatesForShip1);
            playerBoard.Ships.Add(ship);
            return playerBoard;
        }
    }
}
