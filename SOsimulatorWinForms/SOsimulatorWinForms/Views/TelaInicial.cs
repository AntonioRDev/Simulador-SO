using SOsimulatorWinForms.Views;
using System;
using System.Windows.Forms;

namespace SOsimulatorWinForms
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void preemptivoBtn_Click(object sender, EventArgs e)
        {
            var preemptivo = new TelaPreemptivo();            
            preemptivo.ShowDialog(this);
        }

        private void npreemptivoBtn_Click(object sender, EventArgs e)
        {
            var nPreemptivo = new TelaNaoPreemptivo();            
            nPreemptivo.ShowDialog(this);
        }
    }
}
