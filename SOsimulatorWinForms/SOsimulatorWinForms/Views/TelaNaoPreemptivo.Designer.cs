namespace SOsimulatorWinForms.Views
{
    partial class TelaNaoPreemptivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.memoriaListView = new System.Windows.Forms.ListView();
            this.processadorListView = new System.Windows.Forms.ListView();
            this.mmuListView = new System.Windows.Forms.ListView();
            this.btnChrome = new System.Windows.Forms.Button();
            this.btnPowerPoint = new System.Windows.Forms.Button();
            this.btnFirefox = new System.Windows.Forms.Button();
            this.btnPhotoshop = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnPaciencia = new System.Windows.Forms.Button();
            this.btnVisualStudio = new System.Windows.Forms.Button();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.lblApp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // memoriaListView
            // 
            this.memoriaListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Tamanho});
            this.memoriaListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.memoriaListView.Location = new System.Drawing.Point(30, 135);
            this.memoriaListView.Name = "memoriaListView";
            this.memoriaListView.Size = new System.Drawing.Size(134, 288);
            this.memoriaListView.TabIndex = 0;
            this.memoriaListView.UseCompatibleStateImageBehavior = false;
            this.memoriaListView.View = System.Windows.Forms.View.Details;
            // 
            // processadorListView
            // 
            this.processadorListView.Location = new System.Drawing.Point(565, 344);
            this.processadorListView.Name = "processadorListView";
            this.processadorListView.Size = new System.Drawing.Size(171, 79);
            this.processadorListView.TabIndex = 1;
            this.processadorListView.UseCompatibleStateImageBehavior = false;
            // 
            // mmuListView
            // 
            this.mmuListView.Location = new System.Drawing.Point(279, 326);
            this.mmuListView.Name = "mmuListView";
            this.mmuListView.Size = new System.Drawing.Size(168, 97);
            this.mmuListView.TabIndex = 2;
            this.mmuListView.UseCompatibleStateImageBehavior = false;
            // 
            // btnChrome
            // 
            this.btnChrome.Location = new System.Drawing.Point(273, 99);
            this.btnChrome.Name = "btnChrome";
            this.btnChrome.Size = new System.Drawing.Size(93, 23);
            this.btnChrome.TabIndex = 3;
            this.btnChrome.Text = "Google Chrome";
            this.btnChrome.UseVisualStyleBackColor = true;
            this.btnChrome.Click += new System.EventHandler(this.btnChrome_Click);
            // 
            // btnPowerPoint
            // 
            this.btnPowerPoint.Location = new System.Drawing.Point(383, 99);
            this.btnPowerPoint.Name = "btnPowerPoint";
            this.btnPowerPoint.Size = new System.Drawing.Size(93, 23);
            this.btnPowerPoint.TabIndex = 4;
            this.btnPowerPoint.Text = "Power Point";
            this.btnPowerPoint.UseVisualStyleBackColor = true;
            this.btnPowerPoint.Click += new System.EventHandler(this.btnPowerPoint_Click);
            // 
            // btnFirefox
            // 
            this.btnFirefox.Location = new System.Drawing.Point(492, 99);
            this.btnFirefox.Name = "btnFirefox";
            this.btnFirefox.Size = new System.Drawing.Size(93, 23);
            this.btnFirefox.TabIndex = 5;
            this.btnFirefox.Text = "Firefox";
            this.btnFirefox.UseVisualStyleBackColor = true;
            this.btnFirefox.Click += new System.EventHandler(this.btnFirefox_Click);
            // 
            // btnPhotoshop
            // 
            this.btnPhotoshop.Location = new System.Drawing.Point(603, 99);
            this.btnPhotoshop.Name = "btnPhotoshop";
            this.btnPhotoshop.Size = new System.Drawing.Size(93, 23);
            this.btnPhotoshop.TabIndex = 6;
            this.btnPhotoshop.Text = "Photoshop";
            this.btnPhotoshop.UseVisualStyleBackColor = true;
            this.btnPhotoshop.Click += new System.EventHandler(this.btnPhotoshop_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(273, 148);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(93, 23);
            this.btnPaint.TabIndex = 7;
            this.btnPaint.Text = "Paint";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnPaciencia
            // 
            this.btnPaciencia.Location = new System.Drawing.Point(383, 148);
            this.btnPaciencia.Name = "btnPaciencia";
            this.btnPaciencia.Size = new System.Drawing.Size(93, 23);
            this.btnPaciencia.TabIndex = 8;
            this.btnPaciencia.Text = "Paciência";
            this.btnPaciencia.UseVisualStyleBackColor = true;
            this.btnPaciencia.Click += new System.EventHandler(this.btnPaciencia_Click);
            // 
            // btnVisualStudio
            // 
            this.btnVisualStudio.Location = new System.Drawing.Point(492, 148);
            this.btnVisualStudio.Name = "btnVisualStudio";
            this.btnVisualStudio.Size = new System.Drawing.Size(93, 23);
            this.btnVisualStudio.TabIndex = 9;
            this.btnVisualStudio.Text = "Visual Studio";
            this.btnVisualStudio.UseVisualStyleBackColor = true;
            this.btnVisualStudio.Click += new System.EventHandler(this.btnVisualStudio_Click);
            // 
            // btnNotepad
            // 
            this.btnNotepad.Location = new System.Drawing.Point(603, 148);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(93, 23);
            this.btnNotepad.TabIndex = 10;
            this.btnNotepad.Text = "Notepad ++";
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btnNotepad_Click);
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(448, 69);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(73, 13);
            this.lblApp.TabIndex = 11;
            this.lblApp.Text = "APLICAÇÕES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "RAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "MMU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Processador";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            // 
            // Tamanho
            // 
            this.Tamanho.Text = "Tamanho";
            this.Tamanho.Width = 69;
            // 
            // TelaNaoPreemptivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.btnNotepad);
            this.Controls.Add(this.btnVisualStudio);
            this.Controls.Add(this.btnPaciencia);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.btnPhotoshop);
            this.Controls.Add(this.btnFirefox);
            this.Controls.Add(this.btnPowerPoint);
            this.Controls.Add(this.btnChrome);
            this.Controls.Add(this.mmuListView);
            this.Controls.Add(this.processadorListView);
            this.Controls.Add(this.memoriaListView);
            this.Name = "TelaNaoPreemptivo";
            this.Text = "TelaNaoPreemptivo";
            this.Load += new System.EventHandler(this.TelaNaoPreemptivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView memoriaListView;
        private System.Windows.Forms.ListView processadorListView;
        private System.Windows.Forms.ListView mmuListView;
        private System.Windows.Forms.Button btnChrome;
        private System.Windows.Forms.Button btnPowerPoint;
        private System.Windows.Forms.Button btnFirefox;
        private System.Windows.Forms.Button btnPhotoshop;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button btnPaciencia;
        private System.Windows.Forms.Button btnVisualStudio;
        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Tamanho;
    }
}