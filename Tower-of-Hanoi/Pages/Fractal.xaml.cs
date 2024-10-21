using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Tower_of_Hanoi.FractalUtil;

namespace Tower_of_Hanoi.Pages
{
    public partial class Fractal : Page
    {
        private const double BranchLength = 100;

        private CancellationTokenSource _cancellationTokenSource;
        public bool IsGenerationEnabled => _cancellationTokenSource == null || _cancellationTokenSource.IsCancellationRequested;

        public Fractal()
        {
            InitializeComponent();
        }
        private async void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            
            NotifyPropertyChanged(nameof(IsGenerationEnabled));

            try
            {
                await GenerateFractal(_cancellationTokenSource.Token);
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Fractal generation cancelled.");
            }
            finally
            {
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = null;
                NotifyPropertyChanged(nameof(IsGenerationEnabled));
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            _cancellationTokenSource?.Cancel();
        }

        private async Task GenerateFractal(CancellationToken cancellationToken)
        {
            double canvasWidth = FractalCanvas.ActualWidth;
            double canvasHeight = FractalCanvas.ActualHeight;
            double startX = canvasWidth / 2;
            double startY = canvasHeight - 20;

            if (!int.TryParse(DepthTextBox.Text, out int maxRecursionDepth) || maxRecursionDepth < 1)
            {
                MessageBox.Show("Invalid recursion depth. Please enter a positive integer.");
                return;
            }
            
            FractalLogic pythagorasTree = new FractalLogic(FractalCanvas, () => (int)SpeedSlider.Value);
            
            for (int currentDepth = 0; currentDepth <= maxRecursionDepth; currentDepth++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                
                FractalCanvas.Children.Clear();
                
                await pythagorasTree.DrawTree(startX, startY, -Math.PI / 2, currentDepth, BranchLength, cancellationToken);
            }
        }


        private void BackToStartPageButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            Content = null;  // Очищаем контент страницы для освобождения ресурсов
            GC.Collect();    // Принудительный сбор мусора для очистки памяти
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            if (propertyName == nameof(IsGenerationEnabled))
            {
                GenerateButton.IsEnabled = IsGenerationEnabled;
            }
        }
    }
}
