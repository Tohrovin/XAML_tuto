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

namespace XAML_tuto
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly ImageSource[] tileImages = new ImageSource[]
 {
            new BitmapImage(new Uri("Assets/TileEmpty.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileYellow.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileCyan.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileBlue.png",UriKind.Relative)) };

        private readonly Image[,] imageControls;
        private Game gameState = new Game();

        public MainWindow()
        {
            InitializeComponent();
            imageControls = SetupGameCanvas(gameState.map);
        }

        private Image[,] SetupGameCanvas(MapGrid grid)
        {
            Image[,] imageControls = new Image[grid.Rows, grid.Columns];
            int cellSize = 100; //piklele na jedno pole

            for (int r = 0; r < grid.Rows; r++)
            {
                for (int c = 0; c < grid.Columns; c++) //przejechanie po wszystkich polach
                {
                    Image imageControl = new Image
                    {
                        Width = cellSize,
                        Height = cellSize //dodawanie lub zmiana image
                    };

                    Canvas.SetTop(imageControl, r  * cellSize);
                    Canvas.SetLeft(imageControl, c * cellSize); //ustawienie pól na gridzie
                    GameCanvas.Children.Add(imageControl);
                    imageControls[r, c] = imageControl;

                }
            }

            return imageControls;
        }

        private async void GameCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            await szypki_lajl();
        }

        private async Task szypki_lajl()
        {
            while (1 == 1){
                await Task.Delay(500);
                DrawMap(gameState.map);
            }
        }

        private void DrawMap(MapGrid grid)
        {
            for (int r = 0; r < grid.Rows; r++)
            {
                for (int c = 0; c < grid.Columns; c++)
                {
                    int id = grid[r, c];
                    imageControls[r, c].Source = tileImages[id]; //wybranie image na podstawie id w gridzie
                }
            }nj
        }

        private void DrawUnit(MapGrid grid)
        {
            for (int r = 0; r < grid.Rows; r++)
            {
                for (int c = 0; c < grid.Columns; c++)
                {
                    int id = grid[r, c];
                    imageControls[r, c].Source = tileImages[id]; //wybranie image na podstawie id w gridzie
                }
            }
        }


        private void Map_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(e.GetPosition(this).ToString());

    
        }


    }
}
