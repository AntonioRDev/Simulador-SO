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
            this.memoriaListView = new System.Windows.Forms.ListView();
            this.processadorListView = new System.Windows.Forms.ListView();
            this.mmuListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // memoriaListView
            // 
            this.memoriaListView.Location = new System.Drawing.Point(30, 135);
            this.memoriaListView.Name = "memoriaListView";
            this.memoriaListView.Size = new System.Drawing.Size(121, 288);
            this.memoriaListView.TabIndex = 0;
            this.memoriaListView.UseCompatibleStateImageBehavior = false;
            // 
            // processadorListView
            // 
            this.processadorListView.Location = new System.Drawing.Point(547, 344);
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
            // TelaNaoPreemptivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mmuListView);
            this.Controls.Add(this.processadorListView);
            this.Controls.Add(this.memoriaListView);
            this.Name = "TelaNaoPreemptivo";
            this.Text = "TelaNaoPreemptivo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView memoriaListView;
        private System.Windows.Forms.ListView processadorListView;
        private System.Windows.Forms.ListView mmuListView;
    }
}