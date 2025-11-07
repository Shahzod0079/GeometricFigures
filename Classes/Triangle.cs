using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace GeometricFigures
{
    public class Triangle : GeometricFigure
    {
        public double SideLength { get; set; }

        public Triangle(double centerX, double centerY, double sideLength)
            : base(centerX, centerY)
        {
            SideLength = sideLength;
        }

        public override void Draw(Canvas canvas)
        {
            var polygon = new Polygon
            {
                Fill = Brushes.Blue,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            // Вычисляем вершины треугольника
            double height = SideLength * System.Math.Sqrt(3) / 2;

            var points = new PointCollection
            {
                new System.Windows.Point(CenterX, CenterY - height / 2),
                new System.Windows.Point(CenterX - SideLength / 2, CenterY + height / 2),
                new System.Windows.Point(CenterX + SideLength / 2, CenterY + height / 2)
            };

            polygon.Points = points;
            canvas.Children.Add(polygon);
        }
    }
}