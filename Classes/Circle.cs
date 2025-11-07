using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace GeometricFigures
{
    public class Circle : GeometricFigure
    {
        public double Radius { get; set; }

        public Circle(double centerX, double centerY, double radius)
            : base(centerX, centerY)
        {
            Radius = radius;
        }

        public override void Draw(Canvas canvas)
        {
            var ellipse = new Ellipse
            {
                Width = Radius * 2,
                Height = Radius * 2,
                Fill = Brushes.Red,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            Canvas.SetLeft(ellipse, CenterX - Radius);
            Canvas.SetTop(ellipse, CenterY - Radius);

            canvas.Children.Add(ellipse);
        }
    }
}