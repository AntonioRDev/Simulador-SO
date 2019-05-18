using SOsimulatorWPF.Components;
using SOsimulatorWPF.Models;
using System;
using System.Windows;

namespace SOsimulatorWPF.Views
{
    /// <summary>
    /// Interaction logic for NaoPreemptivoWindow.xaml
    /// </summary>
    public partial class NaoPreemptivoWindow : Window
    {
        public NaoPreemptivoWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            RamListView.ItemsSource = RAM.Processos;
        }

        private void Chrome_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Google Chrome";
                app.Tamanho = 128;
                RAM.AdicionarProcesso(app);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Code_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Visual Code";
                app.Tamanho = 128;
                RAM.AdicionarProcesso(app);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Paint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Paint";
                app.Tamanho = 60;
                RAM.AdicionarProcesso(app);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Excel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Excel";
                app.Tamanho = 80;
                RAM.AdicionarProcesso(app);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Firefox_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Firefox";
                app.Tamanho = 100;
                RAM.AdicionarProcesso(app);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Photoshop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Photoshop";
                app.Tamanho = 90;
                RAM.AdicionarProcesso(app);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Paciencia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Paciência";
                app.Tamanho = 50;
                RAM.AdicionarProcesso(app);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Notepad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var app = new Processo();
                app.Nome = "Notepad";
                app.Tamanho = 30;
                RAM.AdicionarProcesso(app);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
