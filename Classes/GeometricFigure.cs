using System.Windows.Controls;

namespace GeometricFigures
{
    public class GeometricFigure
    {
        public double CenterX { get; set; }
        public double CenterY { get; set; }

        public GeometricFigure(double centerX, double centerY)
        {
            CenterX = centerX;
            CenterY = centerY;
        }

        public virtual void Draw(Canvas canvas)
        {
            // Базовая реализация будет в наследниках
        }
    }
}