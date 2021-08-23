
namespace PostgreProductProject
{
    partial class customer
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
            this.dgwMusteri = new System.Windows.Forms.DataGridView();
            this.bttnAddMusteri = new System.Windows.Forms.Button();
            this.bttnDeleteMusteri = new System.Windows.Forms.Button();
            this.bttnUpdateMusteri = new System.Windows.Forms.Button();
            this.txtBmusteriNo = new System.Windows.Forms.TextBox();
            this.txtBmusteriAd = new System.Windows.Forms.TextBox();
            this.txtBmusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtBmusteriSehir = new System.Windows.Forms.TextBox();
            this.labelMusteriNo = new System.Windows.Forms.Label();
            this.labelMusteriAd = new System.Windows.Forms.Label();
            this.labelMusteriSoyad = new System.Windows.Forms.Label();
            this.labelSehir = new System.Windows.Forms.Label();
            this.bttnGoProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMusteri
            // 
            this.dgwMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteri.Location = new System.Drawing.Point(12, 27);
            this.dgwMusteri.Name = "dgwMusteri";
            this.dgwMusteri.RowHeadersWidth = 51;
            this.dgwMusteri.RowTemplate.Height = 24;
            this.dgwMusteri.Size = new System.Drawing.Size(771, 379);
            this.dgwMusteri.TabIndex = 0;
            this.dgwMusteri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteri_CellContentClick);
            // 
            // bttnAddMusteri
            // 
            this.bttnAddMusteri.Location = new System.Drawing.Point(15, 463);
            this.bttnAddMusteri.Name = "bttnAddMusteri";
            this.bttnAddMusteri.Size = new System.Drawing.Size(126, 50);
            this.bttnAddMusteri.TabIndex = 1;
            this.bttnAddMusteri.Text = "müşteri ekle";
            this.bttnAddMusteri.UseVisualStyleBackColor = true;
            this.bttnAddMusteri.Click += new System.EventHandler(this.bttnAddMusteri_Click);
            // 
            // bttnDeleteMusteri
            // 
            this.bttnDeleteMusteri.Location = new System.Drawing.Point(157, 463);
            this.bttnDeleteMusteri.Name = "bttnDeleteMusteri";
            this.bttnDeleteMusteri.Size = new System.Drawing.Size(126, 50);
            this.bttnDeleteMusteri.TabIndex = 2;
            this.bttnDeleteMusteri.Text = "müşteri sil";
            this.bttnDeleteMusteri.UseVisualStyleBackColor = true;
            this.bttnDeleteMusteri.Click += new System.EventHandler(this.bttnDeleteMusteri_Click);
            // 
            // bttnUpdateMusteri
            // 
            this.bttnUpdateMusteri.Location = new System.Drawing.Point(306, 463);
            this.bttnUpdateMusteri.Name = "bttnUpdateMusteri";
            this.bttnUpdateMusteri.Size = new System.Drawing.Size(126, 50);
            this.bttnUpdateMusteri.TabIndex = 3;
            this.bttnUpdateMusteri.Text = "müşteri güncelle";
            this.bttnUpdateMusteri.UseVisualStyleBackColor = true;
            this.bttnUpdateMusteri.Click += new System.EventHandler(this.bttnUpdateMusteri_Click);
            // 
            // txtBmusteriNo
            // 
            this.txtBmusteriNo.Location = new System.Drawing.Point(1057, 72);
            this.txtBmusteriNo.Name = "txtBmusteriNo";
            this.txtBmusteriNo.Size = new System.Drawing.Size(179, 22);
            this.txtBmusteriNo.TabIndex = 4;
            // 
            // txtBmusteriAd
            // 
            this.txtBmusteriAd.Location = new System.Drawing.Point(1057, 126);
            this.txtBmusteriAd.Name = "txtBmusteriAd";
            this.txtBmusteriAd.Size = new System.Drawing.Size(179, 22);
            this.txtBmusteriAd.TabIndex = 5;
            // 
            // txtBmusteriSoyad
            // 
            this.txtBmusteriSoyad.Location = new System.Drawing.Point(1057, 187);
            this.txtBmusteriSoyad.Name = "txtBmusteriSoyad";
            this.txtBmusteriSoyad.Size = new System.Drawing.Size(179, 22);
            this.txtBmusteriSoyad.TabIndex = 6;
            // 
            // txtBmusteriSehir
            // 
            this.txtBmusteriSehir.Location = new System.Drawing.Point(1057, 236);
            this.txtBmusteriSehir.Name = "txtBmusteriSehir";
            this.txtBmusteriSehir.Size = new System.Drawing.Size(179, 22);
            this.txtBmusteriSehir.TabIndex = 7;
            // 
            // labelMusteriNo
            // 
            this.labelMusteriNo.AutoSize = true;
            this.labelMusteriNo.Location = new System.Drawing.Point(907, 72);
            this.labelMusteriNo.Name = "labelMusteriNo";
            this.labelMusteriNo.Size = new System.Drawing.Size(74, 17);
            this.labelMusteriNo.TabIndex = 8;
            this.labelMusteriNo.Text = "müşteri no";
            this.labelMusteriNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMusteriAd
            // 
            this.labelMusteriAd.AutoSize = true;
            this.labelMusteriAd.Location = new System.Drawing.Point(907, 126);
            this.labelMusteriAd.Name = "labelMusteriAd";
            this.labelMusteriAd.Size = new System.Drawing.Size(77, 17);
            this.labelMusteriAd.TabIndex = 9;
            this.labelMusteriAd.Text = "müşteri adı";
            // 
            // labelMusteriSoyad
            // 
            this.labelMusteriSoyad.AutoSize = true;
            this.labelMusteriSoyad.Location = new System.Drawing.Point(907, 192);
            this.labelMusteriSoyad.Name = "labelMusteriSoyad";
            this.labelMusteriSoyad.Size = new System.Drawing.Size(99, 17);
            this.labelMusteriSoyad.TabIndex = 10;
            this.labelMusteriSoyad.Text = "müşteri soyadı";
            this.labelMusteriSoyad.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelSehir
            // 
            this.labelSehir.AutoSize = true;
            this.labelSehir.Location = new System.Drawing.Point(907, 241);
            this.labelSehir.Name = "labelSehir";
            this.labelSehir.Size = new System.Drawing.Size(39, 17);
            this.labelSehir.TabIndex = 11;
            this.labelSehir.Text = "şehir";
            // 
            // bttnGoProducts
            // 
            this.bttnGoProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnGoProducts.Location = new System.Drawing.Point(1000, 569);
            this.bttnGoProducts.Name = "bttnGoProducts";
            this.bttnGoProducts.Size = new System.Drawing.Size(258, 154);
            this.bttnGoProducts.TabIndex = 12;
            this.bttnGoProducts.Text = "Ürünlere git";
            this.bttnGoProducts.UseVisualStyleBackColor = false;
            this.bttnGoProducts.Click += new System.EventHandler(this.bttnGoProducts_Click);
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 776);
            this.Controls.Add(this.bttnGoProducts);
            this.Controls.Add(this.labelSehir);
            this.Controls.Add(this.labelMusteriSoyad);
            this.Controls.Add(this.labelMusteriAd);
            this.Controls.Add(this.labelMusteriNo);
            this.Controls.Add(this.txtBmusteriSehir);
            this.Controls.Add(this.txtBmusteriSoyad);
            this.Controls.Add(this.txtBmusteriAd);
            this.Controls.Add(this.txtBmusteriNo);
            this.Controls.Add(this.bttnUpdateMusteri);
            this.Controls.Add(this.bttnDeleteMusteri);
            this.Controls.Add(this.bttnAddMusteri);
            this.Controls.Add(this.dgwMusteri);
            this.Name = "customer";
            this.Text = "musteri";
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMusteri;
        private System.Windows.Forms.Button bttnAddMusteri;
        private System.Windows.Forms.Button bttnDeleteMusteri;
        private System.Windows.Forms.Button bttnUpdateMusteri;
        private System.Windows.Forms.TextBox txtBmusteriNo;
        private System.Windows.Forms.TextBox txtBmusteriAd;
        private System.Windows.Forms.TextBox txtBmusteriSoyad;
        private System.Windows.Forms.TextBox txtBmusteriSehir;
        private System.Windows.Forms.Label labelMusteriNo;
        private System.Windows.Forms.Label labelMusteriAd;
        private System.Windows.Forms.Label labelMusteriSoyad;
        private System.Windows.Forms.Label labelSehir;
        private System.Windows.Forms.Button bttnGoProducts;
    }
}