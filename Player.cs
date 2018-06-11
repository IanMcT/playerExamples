using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CoolInheritance
{
    internal class Player 
    {
        private Rectangle rectangle;
        private Canvas canvas;
        private static int itemCount = 0;

        public Player(Canvas c)
        {
            canvas = c;
            rectangle = new Rectangle();
            rectangle.Width = 100;
            rectangle.Height = 100;
            rectangle.Fill = Brushes.HotPink;
            canvas.Children.Add(rectangle);
            Canvas.SetLeft(rectangle, itemCount * 200+50);
            itemCount++;
        }

        public void move() {
            double pos = Canvas.GetLeft(this.rectangle);
            Canvas.SetLeft(rectangle, pos + 100);

            
        }

        public double getLeft() {
            return Canvas.GetLeft(this.rectangle);
        }

        public void destroy() {
            canvas.Children.Remove(rectangle);
        }
    }
}
