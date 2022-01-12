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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int clickCount = 0;
        public MainWindow()
        {
            InitializeComponent();
           

        }

     

        private void XOBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Button btn = (Button)sender;
            if (IsXWinner() == true)
            {
                winnerLabel.Content = "Winner is X";
                btn.IsEnabled = false;

            }
            else if (IsOWinner() == true)
            {
                winnerLabel.Content = "Winner is O";
                btn.IsEnabled = false;

            }
            if (btn.Content.ToString().Length < 1)
            {
                clickCount = clickCount + 1;
               
                if (clickCount < 10)
                {
                    if (clickCount % 2 == 0)
                    {

                        btn.Content = "O";
                        winnerLabel.Content = "X on move";
                        if (IsXWinner() == true)
                        {
                            winnerLabel.Content = "Winner is X";
                            btn.IsEnabled = false;

                        }
                        else if (IsOWinner() == true)
                        {
                            winnerLabel.Content = "Winner is O";
                            btn.IsEnabled = false;

                        }
                    }
                    else
                    {
                        btn.Content = "X";
                        winnerLabel.Content = "O on move";
                        if (IsXWinner() == true)
                        {
                            winnerLabel.Content = "Winner is X";
                            btn.IsEnabled = false;

                        }
                        else if (IsOWinner() == true)
                        {
                            winnerLabel.Content = "Winner is O";
                            btn.IsEnabled = false;

                        }
                        else if (clickCount == 9 && IsXWinner() == false && IsOWinner() == false)
                        {
                            winnerLabel.Content = "Its tied!";
                        }
                    }
                }
               
                
            }
            
            

        }

        private bool IsXWinner()
        {
            if (firstRowFirst.Content.ToString() == "X" && firstRowSecond.Content.ToString() == "X" && firstRowThird.Content.ToString() == "X")
            {
                firstRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255,76,41));
                firstRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                firstRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else if (secondRowFirst.Content.ToString() == "X" && secondRowSecond.Content.ToString() == "X" && secondRowThird.Content.ToString() == "X")
            {
                secondRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                secondRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                secondRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else if (thirdRowFirst.Content.ToString() == "X" && thirdRowSecond.Content.ToString() == "X" && thirdRowThird.Content.ToString() == "X")
            {
                thirdRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                thirdRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                thirdRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else if (firstRowFirst.Content.ToString() == "X" && secondRowSecond.Content.ToString() == "X" && thirdRowThird.Content.ToString() == "X")
            {
                firstRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                secondRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                thirdRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else if (firstRowThird.Content.ToString() == "X" && secondRowSecond.Content.ToString() == "X" && thirdRowFirst.Content.ToString() == "X")
            {
                firstRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                secondRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                thirdRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else if (firstRowFirst.Content.ToString() == "X" && secondRowFirst.Content.ToString() == "X" && thirdRowFirst.Content.ToString() == "X")
            {
                firstRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                secondRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                thirdRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else if (firstRowSecond.Content.ToString() == "X" && secondRowSecond.Content.ToString() == "X" && thirdRowSecond.Content.ToString() == "X")
            {
                firstRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                secondRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                thirdRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else if (firstRowThird.Content.ToString() == "X" && secondRowThird.Content.ToString() == "X" && thirdRowThird.Content.ToString() == "X")
            {
                firstRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                secondRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                thirdRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else
            {
                return false;
            }
           
        }
        private bool IsOWinner()
        {
            if (firstRowFirst.Content.ToString() == "O" && firstRowSecond.Content.ToString() == "O" && firstRowThird.Content.ToString() == "O")
            {
                firstRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                firstRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                firstRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else if (secondRowFirst.Content.ToString() == "O" && secondRowSecond.Content.ToString() == "O" && secondRowThird.Content.ToString() == "O")
            {
                secondRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                secondRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                secondRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else if (thirdRowFirst.Content.ToString() == "O" && thirdRowSecond.Content.ToString() == "O" && thirdRowThird.Content.ToString() == "O")
            {
                thirdRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                thirdRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                thirdRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else if (firstRowFirst.Content.ToString() == "O" && secondRowSecond.Content.ToString() == "O" && thirdRowThird.Content.ToString() == "O")
            {
                firstRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                secondRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                thirdRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else if (firstRowThird.Content.ToString() == "O" && secondRowSecond.Content.ToString() == "O" && thirdRowFirst.Content.ToString() == "O")
            {
                firstRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                secondRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                thirdRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else if (firstRowFirst.Content.ToString() == "O" && secondRowFirst.Content.ToString() == "O" && thirdRowFirst.Content.ToString() == "O")
            {
                firstRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                secondRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                thirdRowFirst.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else if (firstRowSecond.Content.ToString() == "O" && secondRowSecond.Content.ToString() == "O" && thirdRowSecond.Content.ToString() == "O")
            {
                firstRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                secondRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                thirdRowSecond.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else if (firstRowThird.Content.ToString() == "O" && secondRowThird.Content.ToString() == "O" && thirdRowThird.Content.ToString() == "O")
            {
                firstRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                secondRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                thirdRowThird.Foreground = new SolidColorBrush(Color.FromRgb(255, 76, 41));
                return true;
            }
            else
            {
                return false;
            }

        }


        private void NewGameBtn_Click(object sender, RoutedEventArgs e)
        {
            clickCount = 0;
            winnerLabel.Content = "";
            firstRowFirst.Content = "";
            firstRowSecond.Content = "";
            firstRowThird.Content = "";
            secondRowFirst.Content = "";
            secondRowSecond.Content = "";
            secondRowThird.Content = "";
            thirdRowFirst.Content = "";
            thirdRowSecond.Content = "";
            thirdRowThird.Content = "";
        }
    }
}
