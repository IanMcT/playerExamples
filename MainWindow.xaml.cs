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

namespace CoolInheritance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Player> players;
//        Player player;
        public MainWindow()
        {
            InitializeComponent();
            players = new List<Player>();
            players.Add(new Player(canvas));
            players.Add(new Player(canvas));
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < players.Count; i++)
            {
                players[i].move();
            }

            for (int i = players.Count - 1; i >= 0; i--) {
                if (players[i].getLeft() >= 450) {
                    players[i].destroy();
                    players.RemoveAt(i);

                }
            }
            //player.move();
        }
    }
}
