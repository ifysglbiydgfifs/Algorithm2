using System;
using System.Windows;
using System.Windows.Controls;
using Tower_of_Hanoi.FractalUtil;

namespace Tower_of_Hanoi.Pages
{
    public partial class Fractal : Page
    {
        public Fractal()
        {
            InitializeComponent();
            Loaded += Fractal_Loaded;
        }

        private void Fractal_Loaded(object sender, RoutedEventArgs e)
        {
            DrawFractalTree();
        }

        private void DrawFractalTree()
        {
            FractalLogic tree = new FractalLogic(FractalCanvas);
            tree.DrawTree(400, 300, -Math.PI / 2, 10, 100);
        }

        private void BackToStartPageButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход обратно на стартовую страницу
            NavigationService.GoBack();
            Content = null;  // Очищаем контент страницы для освобождения ресурсов
            GC.Collect();    // Принудительный сбор мусора для очистки памяти
        }
    }
}