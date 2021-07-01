using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LandMarkAI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fileBrowserButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png; *.jpg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*"; //before the pipe its just text/info for the user

            if(dialog.ShowDialog() == true)
            {
                selectedImagePathTextBox.Text = dialog.FileName;
                selectedImage.Source = new BitmapImage(new Uri(dialog.FileName));
            }
        }

        private void processImageButton_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(selectedImagePathTextBox.Text))
            {
                MessageBox.Show("Please select an image first.");
            }
            else
            {
                CustomVisionAI.CustomVisionAIPredict(this, selectedImagePathTextBox.Text);
            }
        }
    }
}
