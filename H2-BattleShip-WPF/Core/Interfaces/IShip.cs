using System;
using System.Collections.Generic;
using System.Text;

namespace H2_BattleShip_WPF.Core.Interfaces
{
    public interface IShip
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public bool IsAlive { get; set; }
    }
}
