
namespace AkbilYonetimFormUygulamasi
{
    partial class FrmGiris
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
            this.buttonAkbiller = new System.Windows.Forms.Button();
            this.buttonTalimatlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAkbiller
            // 
            this.buttonAkbiller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAkbiller.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAkbiller.Location = new System.Drawing.Point(33, 24);
            this.buttonAkbiller.Name = "buttonAkbiller";
            this.buttonAkbiller.Size = new System.Drawing.Size(275, 140);
            this.buttonAkbiller.TabIndex = 0;
            this.buttonAkbiller.Text = "AKBİL İŞLEMLERİ";
            this.buttonAkbiller.UseVisualStyleBackColor = true;
            this.buttonAkbiller.Click += new System.EventHandler(this.buttonAkbiller_Click);
            // 
            // buttonTalimatlar
            // 
            this.buttonTalimatlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTalimatlar.Location = new System.Drawing.Point(431, 24);
            this.buttonTalimatlar.Name = "buttonTalimatlar";
            this.buttonTalimatlar.Size = new System.Drawing.Size(275, 140);
            this.buttonTalimatlar.TabIndex = 1;
            this.buttonTalimatlar.Text = "TALİMAT İŞLEMLERİ";
            this.buttonTalimatlar.UseVisualStyleBackColor = true;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AkbilYonetimFormUygulamasi.Properties.Resources.Foto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(739, 495);
            this.Controls.Add(this.buttonTalimatlar);
            this.Controls.Add(this.buttonAkbiller);
            this.Name = "FrmGiris";
            this.Text = "AKBİL YÖNETİM UYGULAMASI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAkbiller;
        private System.Windows.Forms.Button buttonTalimatlar;
    }
}

