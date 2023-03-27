namespace FrittoMisto
{
    partial class CustomNarudzbaPrilog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomNarudzbaPrilog));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPomfrit = new System.Windows.Forms.Button();
            this.btnKrompir = new System.Windows.Forms.Button();
            this.btnBlitva = new System.Windows.Forms.Button();
            this.btnNista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "PRILOG:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPomfrit
            // 
            this.btnPomfrit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPomfrit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPomfrit.BackgroundImage")));
            this.btnPomfrit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(216)))), ((int)(((byte)(253)))));
            this.btnPomfrit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPomfrit.Location = new System.Drawing.Point(12, 38);
            this.btnPomfrit.Name = "btnPomfrit";
            this.btnPomfrit.Size = new System.Drawing.Size(129, 100);
            this.btnPomfrit.TabIndex = 19;
            this.btnPomfrit.UseVisualStyleBackColor = true;
            // 
            // btnKrompir
            // 
            this.btnKrompir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKrompir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKrompir.BackgroundImage")));
            this.btnKrompir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(216)))), ((int)(((byte)(253)))));
            this.btnKrompir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKrompir.Location = new System.Drawing.Point(162, 38);
            this.btnKrompir.Name = "btnKrompir";
            this.btnKrompir.Size = new System.Drawing.Size(129, 100);
            this.btnKrompir.TabIndex = 20;
            this.btnKrompir.UseVisualStyleBackColor = true;
            // 
            // btnBlitva
            // 
            this.btnBlitva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBlitva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBlitva.BackgroundImage")));
            this.btnBlitva.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(216)))), ((int)(((byte)(253)))));
            this.btnBlitva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBlitva.Location = new System.Drawing.Point(12, 159);
            this.btnBlitva.Name = "btnBlitva";
            this.btnBlitva.Size = new System.Drawing.Size(129, 100);
            this.btnBlitva.TabIndex = 21;
            this.btnBlitva.UseVisualStyleBackColor = true;
            // 
            // btnNista
            // 
            this.btnNista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNista.BackgroundImage")));
            this.btnNista.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(216)))), ((int)(((byte)(253)))));
            this.btnNista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNista.Location = new System.Drawing.Point(163, 159);
            this.btnNista.Name = "btnNista";
            this.btnNista.Size = new System.Drawing.Size(129, 100);
            this.btnNista.TabIndex = 22;
            this.btnNista.UseVisualStyleBackColor = true;
            this.btnNista.Click += new System.EventHandler(this.button4_Click);
            // 
            // CustomNarudzbaPrilog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(304, 272);
            this.Controls.Add(this.btnNista);
            this.Controls.Add(this.btnBlitva);
            this.Controls.Add(this.btnKrompir);
            this.Controls.Add(this.btnPomfrit);
            this.Controls.Add(this.label1);
            this.Name = "CustomNarudzbaPrilog";
            this.Text = "CustomNarudzbaPrilog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPomfrit;
        private System.Windows.Forms.Button btnKrompir;
        private System.Windows.Forms.Button btnBlitva;
        private System.Windows.Forms.Button btnNista;
    }
}