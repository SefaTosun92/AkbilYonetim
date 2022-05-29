
namespace AkbilYonetimFormUygulamasi
{
    partial class FrmAkbiller
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
            this.components = new System.ComponentModel.Container();
            this.menuStripAkbiller = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talimatlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageAkbilList = new System.Windows.Forms.TabPage();
            this.dataGridViewAkbilList = new System.Windows.Forms.DataGridView();
            this.contextMenuStripAkbilSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlAkbiller = new System.Windows.Forms.TabControl();
            this.tabPageAkbilEkle = new System.Windows.Forms.TabPage();
            this.buttonAkbilEkle = new System.Windows.Forms.Button();
            this.textBoxSeriNumara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAkbilGuncelle = new System.Windows.Forms.TabPage();
            this.menuStripAkbiller.SuspendLayout();
            this.tabPageAkbilList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkbilList)).BeginInit();
            this.contextMenuStripAkbilSil.SuspendLayout();
            this.tabControlAkbiller.SuspendLayout();
            this.tabPageAkbilEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAkbiller
            // 
            this.menuStripAkbiller.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.talimatlarToolStripMenuItem});
            this.menuStripAkbiller.Location = new System.Drawing.Point(0, 0);
            this.menuStripAkbiller.Name = "menuStripAkbiller";
            this.menuStripAkbiller.Size = new System.Drawing.Size(728, 24);
            this.menuStripAkbiller.TabIndex = 0;
            this.menuStripAkbiller.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            // 
            // talimatlarToolStripMenuItem
            // 
            this.talimatlarToolStripMenuItem.Name = "talimatlarToolStripMenuItem";
            this.talimatlarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.talimatlarToolStripMenuItem.Text = "Talimatlar";
            // 
            // tabPageAkbilList
            // 
            this.tabPageAkbilList.Controls.Add(this.dataGridViewAkbilList);
            this.tabPageAkbilList.Location = new System.Drawing.Point(4, 22);
            this.tabPageAkbilList.Name = "tabPageAkbilList";
            this.tabPageAkbilList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAkbilList.Size = new System.Drawing.Size(720, 401);
            this.tabPageAkbilList.TabIndex = 0;
            this.tabPageAkbilList.Text = "Sistemdeki Akbiller";
            this.tabPageAkbilList.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAkbilList
            // 
            this.dataGridViewAkbilList.AllowUserToAddRows = false;
            this.dataGridViewAkbilList.AllowUserToDeleteRows = false;
            this.dataGridViewAkbilList.AllowUserToOrderColumns = true;
            this.dataGridViewAkbilList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAkbilList.ContextMenuStrip = this.contextMenuStripAkbilSil;
            this.dataGridViewAkbilList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAkbilList.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAkbilList.Name = "dataGridViewAkbilList";
            this.dataGridViewAkbilList.ReadOnly = true;
            this.dataGridViewAkbilList.Size = new System.Drawing.Size(714, 395);
            this.dataGridViewAkbilList.TabIndex = 0;
            
            // 
            // contextMenuStripAkbilSil
            // 
            this.contextMenuStripAkbilSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStripAkbilSil.Name = "contextMenuStripAkbilSil";
            this.contextMenuStripAkbilSil.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // tabControlAkbiller
            // 
            this.tabControlAkbiller.Controls.Add(this.tabPageAkbilList);
            this.tabControlAkbiller.Controls.Add(this.tabPageAkbilEkle);
            this.tabControlAkbiller.Controls.Add(this.tabPageAkbilGuncelle);
            this.tabControlAkbiller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAkbiller.Location = new System.Drawing.Point(0, 24);
            this.tabControlAkbiller.Name = "tabControlAkbiller";
            this.tabControlAkbiller.SelectedIndex = 0;
            this.tabControlAkbiller.Size = new System.Drawing.Size(728, 427);
            this.tabControlAkbiller.TabIndex = 1;
            // 
            // tabPageAkbilEkle
            // 
            this.tabPageAkbilEkle.Controls.Add(this.buttonAkbilEkle);
            this.tabPageAkbilEkle.Controls.Add(this.textBoxSeriNumara);
            this.tabPageAkbilEkle.Controls.Add(this.label2);
            this.tabPageAkbilEkle.Controls.Add(this.textBoxAdSoyad);
            this.tabPageAkbilEkle.Controls.Add(this.label1);
            this.tabPageAkbilEkle.Location = new System.Drawing.Point(4, 22);
            this.tabPageAkbilEkle.Name = "tabPageAkbilEkle";
            this.tabPageAkbilEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAkbilEkle.Size = new System.Drawing.Size(720, 401);
            this.tabPageAkbilEkle.TabIndex = 1;
            this.tabPageAkbilEkle.Text = "Yeni Akbil Ekle";
            this.tabPageAkbilEkle.UseVisualStyleBackColor = true;
            // 
            // buttonAkbilEkle
            // 
            this.buttonAkbilEkle.Location = new System.Drawing.Point(327, 248);
            this.buttonAkbilEkle.Name = "buttonAkbilEkle";
            this.buttonAkbilEkle.Size = new System.Drawing.Size(102, 50);
            this.buttonAkbilEkle.TabIndex = 4;
            this.buttonAkbilEkle.Text = "Kaydet";
            this.buttonAkbilEkle.UseVisualStyleBackColor = true;
            this.buttonAkbilEkle.Click += new System.EventHandler(this.buttonAkbilEkle_Click);
            // 
            // textBoxSeriNumara
            // 
            this.textBoxSeriNumara.Location = new System.Drawing.Point(435, 154);
            this.textBoxSeriNumara.Name = "textBoxSeriNumara";
            this.textBoxSeriNumara.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeriNumara.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(208, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seri Numarası:";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(435, 103);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(208, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // tabPageAkbilGuncelle
            // 
            this.tabPageAkbilGuncelle.Location = new System.Drawing.Point(4, 22);
            this.tabPageAkbilGuncelle.Name = "tabPageAkbilGuncelle";
            this.tabPageAkbilGuncelle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAkbilGuncelle.Size = new System.Drawing.Size(720, 401);
            this.tabPageAkbilGuncelle.TabIndex = 2;
            this.tabPageAkbilGuncelle.Text = "Akbil Bilgileri Güncelle";
            this.tabPageAkbilGuncelle.UseVisualStyleBackColor = true;
            // 
            // FrmAkbiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 451);
            this.Controls.Add(this.tabControlAkbiller);
            this.Controls.Add(this.menuStripAkbiller);
            this.MainMenuStrip = this.menuStripAkbiller;
            this.Name = "FrmAkbiller";
            this.Text = "AKBİL İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmAkbiller_Load);
            this.menuStripAkbiller.ResumeLayout(false);
            this.menuStripAkbiller.PerformLayout();
            this.tabPageAkbilList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkbilList)).EndInit();
            this.contextMenuStripAkbilSil.ResumeLayout(false);
            this.tabControlAkbiller.ResumeLayout(false);
            this.tabPageAkbilEkle.ResumeLayout(false);
            this.tabPageAkbilEkle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAkbiller;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talimatlarToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageAkbilList;
        private System.Windows.Forms.TabControl tabControlAkbiller;
        private System.Windows.Forms.TabPage tabPageAkbilEkle;
        private System.Windows.Forms.Button buttonAkbilEkle;
        private System.Windows.Forms.TextBox textBoxSeriNumara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageAkbilGuncelle;
        private System.Windows.Forms.DataGridView dataGridViewAkbilList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAkbilSil;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}