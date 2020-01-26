namespace FaceRecoEmcv2
{
    partial class FrmPersFaceInsert
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
            this.imgYuz = new System.Windows.Forms.PictureBox();
            this.imgKamera = new System.Windows.Forms.PictureBox();
            this.btnResimCek = new MetroFramework.Controls.MetroButton();
            this.lblAdet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgYuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKamera)).BeginInit();
            this.SuspendLayout();
            // 
            // imgYuz
            // 
            this.imgYuz.Location = new System.Drawing.Point(562, 74);
            this.imgYuz.Name = "imgYuz";
            this.imgYuz.Size = new System.Drawing.Size(212, 170);
            this.imgYuz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgYuz.TabIndex = 27;
            this.imgYuz.TabStop = false;
            // 
            // imgKamera
            // 
            this.imgKamera.Location = new System.Drawing.Point(36, 74);
            this.imgKamera.Name = "imgKamera";
            this.imgKamera.Size = new System.Drawing.Size(520, 331);
            this.imgKamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgKamera.TabIndex = 26;
            this.imgKamera.TabStop = false;
            // 
            // btnResimCek
            // 
            this.btnResimCek.Location = new System.Drawing.Point(604, 263);
            this.btnResimCek.Name = "btnResimCek";
            this.btnResimCek.Size = new System.Drawing.Size(144, 27);
            this.btnResimCek.TabIndex = 28;
            this.btnResimCek.Text = "Resim Çek";
            this.btnResimCek.UseSelectable = true;
            this.btnResimCek.Click += new System.EventHandler(this.btnResimCek_Click);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(658, 305);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(35, 13);
            this.lblAdet.TabIndex = 30;
            this.lblAdet.Text = "label2";
            // 
            // FrmPersFaceInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.btnResimCek);
            this.Controls.Add(this.imgYuz);
            this.Controls.Add(this.imgKamera);
            this.Name = "FrmPersFaceInsert";
            this.Text = "RESİM EKLE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPersFaceInsert_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPersFaceInsert_FormClosed);
            this.Load += new System.EventHandler(this.FrmPersFaceInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgYuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgYuz;
        private System.Windows.Forms.PictureBox imgKamera;
        private MetroFramework.Controls.MetroButton btnResimCek;
        private System.Windows.Forms.Label lblAdet;
    }
}