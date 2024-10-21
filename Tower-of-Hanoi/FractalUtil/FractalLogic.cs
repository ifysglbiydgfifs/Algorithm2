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
        public async Task DrawTree(double x, double y, double angle, int depth, double length, CancellationToken cancellationToken)
        {
            if (depth == 0 || cancellationToken.IsCancellationRequested) return;
            
            double xEnd = x + length * Math.Cos(angle);
            double yEnd = y + length * Math.Sin(angle);

            DrawBranch(x, y, xEnd, yEnd);

            await Task.Delay(1);

            await DrawTree(xEnd, yEnd, angle - Math.PI / 4, depth - 1, length * 0.7, cancellationToken);
            await DrawTree(xEnd, yEnd, angle + Math.PI / 4, depth - 1, length * 0.7, cancellationToken);
        }
        private void DrawBranch(double x1, double y1, double x2, double y2)
        {
            Line line = new Line
            {
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2,
                Stroke = Brushes.Green,
                StrokeThickness = 2
            };
            _canvas.Children.Add(line);
        }
    }
}