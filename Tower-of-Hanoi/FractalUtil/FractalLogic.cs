using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tower_of_Hanoi.FractalUtil
{
    public class FractalLogic
    {
        private readonly Canvas _canvas;

        public FractalLogic(Canvas canvas)
        {
            _canvas = canvas;
        }

        public void DrawTree(double x, double y, double angle, int depth, double length)
        {
            if (depth == 0) return;

            // Конечная точка для текущей ветки
            double x1 = x + length * Math.Cos(angle);
            double y1 = y - length * Math.Sin(angle);  // Уменьшаем Y, так как ось Y идёт вниз

            // Рисуем ветку
            DrawLine(x, y, x1, y1);

            // Рекурсивно рисуем левую и правую ветки
            DrawTree(x1, y1, angle - Math.PI / 4, depth - 1, length * 0.7); // Левая ветка
            DrawTree(x1, y1, angle + Math.PI / 4, depth - 1, length * 0.7); // Правая ветка
        }

        private void DrawLine(double x1, double y1, double x2, double y2)
        {
            var line = new System.Windows.Shapes.Line
            {
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            _canvas.Children.Add(line);
        }
    }
}