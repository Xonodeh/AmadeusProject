using System;
using System.IO; // Nécessaire pour vérifier si le fichier existe
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging; // Nécessaire pour gérer les Bitmaps
using AmadeusProject.Services;

namespace AmadeusProject
{
    public partial class MainWindow : Window
    {
        SpriteManager _spriteManager;

        public MainWindow()
        {
            InitializeComponent();

            _spriteManager = new SpriteManager();

        
            string initialPath = _spriteManager.GetSpritePath("[HAPPY]");

            if (File.Exists(initialPath))
            {
                KurisuDisplay.Source = new BitmapImage(new Uri(initialPath, UriKind.Absolute));
            }
            else
            {
                MessageBox.Show($"Impossible de trouver l'image ici :\n{initialPath}\n\nVérifie que tes images sont bien dans le dossier 'Assets' et en mode 'Copier si plus récent'.");
            }

            this.MouseDown += (s, e) => { if (e.LeftButton == MouseButtonState.Pressed) DragMove(); };
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e) { }
        private void UserInput_KeyDown(object sender, KeyEventArgs e) { }
    }
}