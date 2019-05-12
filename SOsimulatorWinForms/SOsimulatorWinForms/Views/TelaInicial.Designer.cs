namespace SOsimulatorWinForms
{
    partial class TelaInicial
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
            this.label1 = new System.Windows.Forms.Label();
            this.preemptivoBtn = new System.Windows.Forms.Button();
            this.npreemptivoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESCOLHA O TIPO DE ESCALONAMENTO";
            // 
            // preemptivoBtn
            // 
            this.preemptivoBtn.Location = new System.Drawing.Point(210, 191);
            this.preemptivoBtn.Name = "preemptivoBtn";
            this.preemptivoBtn.Size = new System.Drawing.Size(112, 23);
            this.preemptivoBtn.TabIndex = 1;
            this.preemptivoBtn.Text = "PREEMPTIVO";
            this.preemptivoBtn.UseVisualStyleBackColor = true;
            this.preemptivoBtn.Click += new System.EventHandler(this.preemptivoBtn_Click);
            // 
            // npreemptivoBtn
            // 
            this.npreemptivoBtn.Location = new System.Drawing.Point(335, 191);
            this.npreemptivoBtn.Name = "npreemptivoBtn";
            this.npreemptivoBtn.Size = new System.Drawing.Size(112, 23);
            this.npreemptivoBtn.TabIndex = 2;
            this.npreemptivoBtn.Text = "NÃO PREEMPTIVO";
            this.npreemptivoBtn.UseVisualStyleBackColor = true;
            this.npreemptivoBtn.Click += new System.EventHandler(this.npreemptivoBtn_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(645, 342);
            this.Controls.Add(this.npreemptivoBtn);
            this.Controls.Add(this.preemptivoBtn);
            this.Controls.Add(this.label1);
            this.Name = "TelaInicial";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button preemptivoBtn;
        private System.Windows.Forms.Button npreemptivoBtn;
    }
}

