using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using H2_BattleShip_WPF.Core.Coordinate;
using H2_BattleShip_WPF.Core.Manager;

namespace H2_BattleShip_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameManager game;
        public MainWindow()
        {
            InitializeComponent();
            game = new GameManager();
            foreach (var ship in game.Players.FirstOrDefault().OwnBoard.Ships)
            {
                foreach (_2DCoordinate coordinate in ship.Coordinates)
                {
                    
                    Label label = new Label();
                    label.Name = ship.Name;
                    label.Content = ship.Name;
                    Grid.SetRow(label, coordinate.X);

                    Grid.SetColumn(label, coordinate.Y);
                    Gridd.Children.Add(label);
                }
            }
        }
        
    }
}
