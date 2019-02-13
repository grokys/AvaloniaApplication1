using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;

namespace AvaloniaApplication1.Views
{
    public class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
        }
    }
}
