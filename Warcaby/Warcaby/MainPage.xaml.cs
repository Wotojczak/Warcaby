using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Warcaby
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CreateBoard();
            CreateCheckers();
        }

        private void CreateBoard()
        {
            Grid boardGrid = (Grid)FindByName("Board");

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Frame square = new Frame
                    {
                        BackgroundColor = (row + col) % 2 == 0 ? Color.White : Color.Black,
                        Padding = 0,
                        Margin = 0,
                        HasShadow = false,
                        CornerRadius = 0
                    };
                    boardGrid.Children.Add(square, col, row);
                }
            }
            Content = boardGrid;
        }

        private void CreateCheckers()
        {
            Grid boardGrid = (Grid)Content;

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if ((row + col) % 2 == 1 && row < 3)
                    {
                        Image blackChecker = new Image
                        {
                            Source = "black_checker.png",
                            Aspect = Aspect.AspectFit,
                            HeightRequest = 50,
                            WidthRequest = 50,
                            VerticalOptions = LayoutOptions.Center,
                            HorizontalOptions = LayoutOptions.Center,
                            InputTransparent = true
                        };
                        var tapGesture = new TapGestureRecognizer();
                        tapGesture.Tapped += (sender, e) =>
                        {

                        };
                        blackChecker.GestureRecognizers.Add(tapGesture);
                        boardGrid.Children.Add(blackChecker, row, col);
                    }
                    else if((row + col) % 2 == 1 && row > 4)
                    {
                        Image whiteChecker = new Image
                        {
                            Source = "white_checker.png",
                            Aspect = Aspect.AspectFit,
                            HeightRequest = 50,
                            WidthRequest = 50,
                            VerticalOptions = LayoutOptions.Center,
                            HorizontalOptions = LayoutOptions.Center,
                            InputTransparent = true
                        };
                        var tapGesture = new TapGestureRecognizer();
                        tapGesture.Tapped += (sender, e) =>
                        {

                        };
                        whiteChecker.GestureRecognizers.Add(tapGesture);
                        boardGrid.Children.Add(whiteChecker, row, col);
                    }
                }
            }
        }
        
        
    }
}