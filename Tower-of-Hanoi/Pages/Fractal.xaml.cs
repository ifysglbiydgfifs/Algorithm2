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
        private const double BranchLength = 100;  // Константная длина ветвей

        private CancellationTokenSource _cancellationTokenSource;
        public bool IsGenerationEnabled => _cancellationTokenSource == null || _cancellationTokenSource.IsCancellationRequested;

        public Fractal()
        {
            InitializeComponent();
            Loaded += Fractal_Loaded;
        }

        private void Fractal_Loaded(object sender, RoutedEventArgs e)
        {
            // Логика при загрузке страницы
        }

        private async void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            _cancellationTokenSource = new CancellationTokenSource();

            // Заблокировать кнопку Generate
            NotifyPropertyChanged(nameof(IsGenerationEnabled));

            try
            {
                await DrawFractalTreeAsync(_cancellationTokenSource.Token);
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Fractal generation cancelled.");
            }
            finally
            {
                // Разблокировать кнопку Generate
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = null;
                NotifyPropertyChanged(nameof(IsGenerationEnabled));
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            _cancellationTokenSource?.Cancel();
        }

        private async Task DrawFractalTreeAsync(CancellationToken cancellationToken)
        {
            // Автоматически вычисляем координаты x и y для начала в центре Canvas
            double canvasWidth = FractalCanvas.ActualWidth;
            double canvasHeight = FractalCanvas.ActualHeight;
            double startX = canvasWidth / 2;
            double startY = canvasHeight - 20;  // Начало снизу, отступ 20 пикселей

            // Читаем глубину рекурсии из текстбокса
            if (!int.TryParse(DepthTextBox.Text, out int maxRecursionDepth) || maxRecursionDepth < 1)
            {
                MessageBox.Show("Invalid recursion depth. Please enter a positive integer.");
                return;
            }

            // Создаем объект для рисования фрактала
            FractalLogic tree = new FractalLogic(FractalCanvas);

            // Поэтапная отрисовка фрактала для каждой глубины от 1 до maxRecursionDepth
            for (int currentDepth = 1; currentDepth <= maxRecursionDepth; currentDepth++)
            {
                // Проверяем токен отмены, если отмена, выходим из цикла
                cancellationToken.ThrowIfCancellationRequested();

                // Очищаем холст перед новой отрисовкой
                FractalCanvas.Children.Clear();

                // Рисуем дерево для текущей глубины рекурсии
                await tree.DrawTreeAsync(startX, startY, -Math.PI / 2, currentDepth, BranchLength, cancellationToken);

                // Добавляем небольшую задержку для наглядной поэтапной отрисовки
                await Task.Delay(5, cancellationToken);  // 500 мс пауза между уровнями
            }
        }

        private void BackToStartPageButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход обратно на стартовую страницу
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
