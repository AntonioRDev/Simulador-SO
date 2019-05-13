using SOsimulatorWinForms.Componentes;
using SOsimulatorWinForms.Model;
using System;
using System.Windows.Forms;

namespace SOsimulatorWinForms.Views
{
    public partial class TelaNaoPreemptivo : Form
    {
        public TelaNaoPreemptivo()
        {
            InitializeComponent();
        }

        private void TelaNaoPreemptivo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnChrome_Click(object sender, EventArgs e)
        {
            var app = new Aplicação();
            app.Nome = "Google Chrome";
            app.Tamanho = 128;
            RAM.AdicionarProcesso(app);

            ListViewItem item = new ListViewItem(app.Nome);
            item.SubItems.Add(app.Tamanho.ToString());
            memoriaListView.Items.Add(item);
        }

        private void btnPowerPoint_Click(object sender, EventArgs e)
        {
            var app = new Aplicação();
            app.Nome = "Power Point";
            app.Tamanho = 80;
            RAM.AdicionarProcesso(app);
        }

        private void btnFirefox_Click(object sender, EventArgs e)
        {
            var app = new Aplicação();
            app.Nome = "Firefox";
            app.Tamanho = 100;
            RAM.AdicionarProcesso(app);
        }

        private void btnPhotoshop_Click(object sender, EventArgs e)
        {
            var app = new Aplicação();
            app.Nome = "Photoshop";
            app.Tamanho = 90;
            RAM.AdicionarProcesso(app);
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            var app = new Aplicação();
            app.Nome = "Paint";
            app.Tamanho = 60;
            RAM.AdicionarProcesso(app);
        }

        private void btnPaciencia_Click(object sender, EventArgs e)
        {
            var app = new Aplicação();
            app.Nome = "Paciência";
            app.Tamanho = 40;
            RAM.AdicionarProcesso(app);
        }

        private void btnVisualStudio_Click(object sender, EventArgs e)
        {
            var app = new Aplicação();
            app.Nome = "Visual Studio";
            app.Tamanho = 128;
            RAM.AdicionarProcesso(app);
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            var app = new Aplicação();
            app.Nome = "Notepad ++";
            app.Tamanho = 30;
            RAM.AdicionarProcesso(app);
        }
    }
}
