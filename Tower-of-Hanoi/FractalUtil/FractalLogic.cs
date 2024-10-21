using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Tower_of_Hanoi.FractalUtil
{
    public class FractalLogic
    {
        private readonly Canvas _canvas;

        public FractalLogic(Canvas canvas)
        {
            _canvas = canvas;
        }

        // Асинхронный метод для пошаговой отрисовки дерева
        public async Task DrawTreeAsync(double x, double y, double angle, int depth, double length, CancellationToken cancellationToken)
        {
            if (depth == 0 || cancellationToken.IsCancellationRequested) return;

            // Вычисляем конечные координаты ветви
            double xEnd = x + length * Math.Cos(angle);
            double yEnd = y + length * Math.Sin(angle);

            // Рисуем линию ветви
            DrawLine(x, y, xEnd, yEnd);

            // Задержка для пошаговой визуализации
            await Task.Delay(1);  // 500 миллисекунд задержки между уровнями

            // Рекурсивный вызов для рисования новых ветвей
            await DrawTreeAsync(xEnd, yEnd, angle - Math.PI / 4, depth - 1, length * 0.7, cancellationToken);
            await DrawTreeAsync(xEnd, yEnd, angle + Math.PI / 4, depth - 1, length * 0.7, cancellationToken);
        }

        // Метод для рисования линии
        private void DrawLine(double x1, double y1, double x2, double y2)
        {
            Line line = new Line
            {
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2,
                Stroke = Brushes.Green,  // Цвет ветвей
                StrokeThickness = 2      // Толщина линии
            };

            // Добавляем линию на холст
            _canvas.Children.Add(line);
        }
    }
}