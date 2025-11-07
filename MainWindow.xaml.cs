using System.Windows;

namespace GeometricFigures
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            // Создаем фигуры
            var triangle = new Triangle(100, 100, 80);
            var circle = new Circle(250, 150, 50);
            var triangle2 = new Triangle(400, 200, 60);
            var circle2 = new Circle(150, 300, 40);

            // Рисуем фигуры на Canvas
            triangle.Draw(MainCanvas);
            circle.Draw(MainCanvas);
            triangle2.Draw(MainCanvas);
            circle2.Draw(MainCanvas);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            // Очищаем Canvas
            MainCanvas.Children.Clear();
        }
    }
}