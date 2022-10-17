
namespace Savas_Ucagi_Oyunu
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.UstBilgiPaneli = new System.Windows.Forms.Panel();
            this.lblSüre = new System.Windows.Forms.Label();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.AltUcakPaneli = new System.Windows.Forms.Panel();
            this.AnaSavaspaneli = new System.Windows.Forms.Panel();
            this.UstBilgiPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // UstBilgiPaneli
            // 
            this.UstBilgiPaneli.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UstBilgiPaneli.Controls.Add(this.lblSüre);
            this.UstBilgiPaneli.Controls.Add(this.lblBilgi);
            this.UstBilgiPaneli.Dock = System.Windows.Forms.DockStyle.Top;
            this.UstBilgiPaneli.Location = new System.Drawing.Point(0, 0);
            this.UstBilgiPaneli.Name = "UstBilgiPaneli";
            this.UstBilgiPaneli.Size = new System.Drawing.Size(1129, 118);
            this.UstBilgiPaneli.TabIndex = 0;
            // 
            // lblSüre
            // 
            this.lblSüre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSüre.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSüre.ForeColor = System.Drawing.Color.White;
            this.lblSüre.Location = new System.Drawing.Point(893, 25);
            this.lblSüre.Name = "lblSüre";
            this.lblSüre.Size = new System.Drawing.Size(217, 62);
            this.lblSüre.TabIndex = 1;
            this.lblSüre.Text = "0:00";
            this.lblSüre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(7, 11);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(643, 92);
            this.lblBilgi.TabIndex = 0;
            this.lblBilgi.Text = resources.GetString("lblBilgi.Text");
            // 
            // AltUcakPaneli
            // 
            this.AltUcakPaneli.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.AltUcakPaneli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AltUcakPaneli.Location = new System.Drawing.Point(0, 691);
            this.AltUcakPaneli.Name = "AltUcakPaneli";
            this.AltUcakPaneli.Size = new System.Drawing.Size(1129, 60);
            this.AltUcakPaneli.TabIndex = 1;
            // 
            // AnaSavaspaneli
            // 
            this.AnaSavaspaneli.BackColor = System.Drawing.Color.Red;
            this.AnaSavaspaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnaSavaspaneli.Location = new System.Drawing.Point(0, 118);
            this.AnaSavaspaneli.Name = "AnaSavaspaneli";
            this.AnaSavaspaneli.Size = new System.Drawing.Size(1129, 573);
            this.AnaSavaspaneli.TabIndex = 2;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 751);
            this.Controls.Add(this.AnaSavaspaneli);
            this.Controls.Add(this.AltUcakPaneli);
            this.Controls.Add(this.UstBilgiPaneli);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Anasayfa_KeyDown);
            this.UstBilgiPaneli.ResumeLayout(false);
            this.UstBilgiPaneli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UstBilgiPaneli;
        private System.Windows.Forms.Panel AltUcakPaneli;
        private System.Windows.Forms.Panel AnaSavaspaneli;
        private System.Windows.Forms.Label lblSüre;
        private System.Windows.Forms.Label lblBilgi;
    }
}