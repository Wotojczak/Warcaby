using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Shapes;
using Xamarin.Forms;

namespace Warcaby
{
    public partial class MainPage : ContentPage
    {
        private Grid _boardGrid;
        private Ellipse _selectedChecker;

        public MainPage()
        {
            InitializeComponent();
            CreateBoard();
            CreateCheckers();
            this.BackgroundColor = Color.DarkGreen;
        }

        private void CreateBoard()
        {
            StackLayout background = (StackLayout)FindByName("Background");
            _boardGrid = (Grid)FindByName("Board");

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Frame square = new Frame
                    {
                        BackgroundColor = (row + col) % 2 == 0 ? Color.White : Color.Black,
                        WidthRequest = 50,
                        HeightRequest = 50,
                        Margin = new Thickness(0),
                        Padding = new Thickness(0),
                        HasShadow = false
                    };
                    
                    _boardGrid.Children.Add(square, col, row);
                }
            }

            Content = _boardGrid;
        }

        private void CreateCheckers()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (((row + col) % 2 == 1 && row < 3))
                    {
                        Ellipse blackChecker = new Ellipse
                        {
                            Fill = new SolidColorBrush(Color.DimGray),
                            HeightRequest = 50,
                            WidthRequest = 50,
                            Margin = new Thickness(0),
                            VerticalOptions = LayoutOptions.Center,
                            HorizontalOptions = LayoutOptions.Center,
                            InputTransparent = true
                        };
                       // blackChecker.GestureRecognizers.Add(new TapGestureRecognizer
                        //    { Command = new Command(() => OnCheckerTapped(blackChecker)) });
                        _boardGrid.Children.Add(blackChecker, col, row);
                    }
                    else if ((row + col) % 2 == 1 && row > 4)
                    {
                        Ellipse whiteChecker = new Ellipse
                        {
                            Fill = new SolidColorBrush(Color.White),
                            HeightRequest = 50,
                            WidthRequest = 50,
                            Margin = new Thickness(0),
                            VerticalOptions = LayoutOptions.Center,
                            HorizontalOptions = LayoutOptions.Center,
                            InputTransparent = true
                        };
                       // whiteChecker.GestureRecognizers.Add(new TapGestureRecognizer
                       //     { Command = new Command(() => OnCheckerTapped(whiteChecker)) });
                        _boardGrid.Children.Add(whiteChecker, col, row);
                    }
                }
            }
        }

        private void OnCheckerTapped(object sender, EventArgs e)
        {
            //if ()
            {
                
            }
        }

        private void IsMoveValid(object sender, EventArgs e)
        {
            
        }
    }
}