using System;
using System.Windows;

namespace HelloWPFApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            String content;

            if (Button1.IsChecked == true)
            {
                content = Button1.Content.ToString();
            }
            else if (Button2.IsChecked == true)
            {
                content = Button2.Content.ToString();
            }
            else
            {
                ShowContent("No button selected");
                return;
            }

            ShowContent(content);   
        }

        private void ShowContent(String content)
        {
            MessageBox.Show(content);
        }
    }
}
