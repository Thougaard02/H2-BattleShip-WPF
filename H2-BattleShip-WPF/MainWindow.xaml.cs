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
using H2_BattleShip_WPF.Core.Board;
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
            CreateRowDefinition();
            CreateColumnDefinition();
            CreateGrid();
        }

        private void ShowAllShips()
        {
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
        private void PlaceShip()
        {

        } 

        private void mouseClick(object sender, MouseButtonEventArgs e)
        {
            Background = Brushes.Black;
        }

        public void CreateRowDefinition()
        {
            for (int i = 0; i < 10; i++)
            {
                RowDefinition rowDefinition = new RowDefinition();
                Gridd.RowDefinitions.Add(rowDefinition);
            }

        }

        public void CreateColumnDefinition()
        {
            for (int i = 0; i < 10; i++)
            {

                ColumnDefinition columnDefinition = new ColumnDefinition();
                Gridd.ColumnDefinitions.Add(columnDefinition);
            }
        }
        public void CreateGrid()
        {
            for (int i = 0; i < Gridd.RowDefinitions.Count; i++)
            {
                for (int j = 0; j < Gridd.ColumnDefinitions.Count; j++)
                {
                    Grid grid = new Grid();
                    Grid.SetRow(grid,i);
                    Grid.SetColumn(grid, j);
                    grid.Name = $"Grid{i}{j}";
                    grid.MouseDown += new MouseButtonEventHandler(mouseClick);
                    grid.Background = Brushes.Black;
                    Gridd.Children.Add(grid);
                }
            }
        }
    }
}
