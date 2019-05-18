using SOsimulatorWPF.Views;
using System.Windows;

namespace SOsimulatorWPF
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

        private void Preemptivo_Click(object sender, RoutedEventArgs e)
        {
            PreemptivoWindow preemptivoWindow = new PreemptivoWindow();
            preemptivoWindow.ShowDialog();
        }

        private void NaoPreemptivo_Click(object sender, RoutedEventArgs e)
        {
            NaoPreemptivoWindow naoPreemptivoWindow = new NaoPreemptivoWindow();
            naoPreemptivoWindow.ShowDialog();
        }
    }
}
