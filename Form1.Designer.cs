namespace RandomNoiseGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btExport = new System.Windows.Forms.Button();
            this.btNewImage = new System.Windows.Forms.Button();
            this.lbDim = new System.Windows.Forms.Label();
            this.tbDim = new System.Windows.Forms.TextBox();
            this.lbVar = new System.Windows.Forms.Label();
            this.tbVar = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(13, 13);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(536, 536);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(578, 517);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(194, 32);
            this.btExport.TabIndex = 1;
            this.btExport.Text = "Export Image";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btNewImage
            // 
            this.btNewImage.Location = new System.Drawing.Point(578, 144);
            this.btNewImage.Name = "btNewImage";
            this.btNewImage.Size = new System.Drawing.Size(194, 32);
            this.btNewImage.TabIndex = 2;
            this.btNewImage.Text = "Generate New Image";
            this.btNewImage.UseVisualStyleBackColor = true;
            this.btNewImage.Click += new System.EventHandler(this.btNewImage_Click);
            // 
            // lbDim
            // 
            this.lbDim.AutoSize = true;
            this.lbDim.Location = new System.Drawing.Point(575, 13);
            this.lbDim.Name = "lbDim";
            this.lbDim.Size = new System.Drawing.Size(56, 13);
            this.lbDim.TabIndex = 3;
            this.lbDim.Text = "Dimension";
            // 
            // tbDim
            // 
            this.tbDim.Location = new System.Drawing.Point(578, 29);
            this.tbDim.Name = "tbDim";
            this.tbDim.Size = new System.Drawing.Size(194, 20);
            this.tbDim.TabIndex = 4;
            // 
            // lbVar
            // 
            this.lbVar.AutoSize = true;
            this.lbVar.Location = new System.Drawing.Point(575, 74);
            this.lbVar.Name = "lbVar";
            this.lbVar.Size = new System.Drawing.Size(39, 13);
            this.lbVar.TabIndex = 5;
            this.lbVar.Text = "Variety";
            // 
            // tbVar
            // 
            this.tbVar.Location = new System.Drawing.Point(578, 90);
            this.tbVar.Name = "tbVar";
            this.tbVar.Size = new System.Drawing.Size(194, 20);
            this.tbVar.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbVar);
            this.Controls.Add(this.lbVar);
            this.Controls.Add(this.tbDim);
            this.Controls.Add(this.lbDim);
            this.Controls.Add(this.btNewImage);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.picBox);
            this.Name = "Form1";
            this.Text = "Random Noise Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btNewImage;
        private System.Windows.Forms.Label lbDim;
        private System.Windows.Forms.TextBox tbDim;
        private System.Windows.Forms.Label lbVar;
        private System.Windows.Forms.TextBox tbVar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

