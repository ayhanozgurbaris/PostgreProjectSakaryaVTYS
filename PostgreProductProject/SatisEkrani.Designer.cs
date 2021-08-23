
namespace PostgreProductProject
{
    partial class SatisEkrani
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
            this.bttnGoProducts = new System.Windows.Forms.Button();
            this.dgwMusteri = new System.Windows.Forms.DataGridView();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.btnUrunl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnGoProducts
            // 
            this.bttnGoProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnGoProducts.Location = new System.Drawing.Point(232, 510);
            this.bttnGoProducts.Name = "bttnGoProducts";
            this.bttnGoProducts.Size = new System.Drawing.Size(210, 66);
            this.bttnGoProducts.TabIndex = 25;
            this.bttnGoProducts.Text = "Satisi Tamamla";
            this.bttnGoProducts.UseVisualStyleBackColor = false;
            this.bttnGoProducts.Click += new System.EventHandler(this.bttnGoProducts_Click);
            // 
            // dgwMusteri
            // 
            this.dgwMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteri.Location = new System.Drawing.Point(12, 64);
            this.dgwMusteri.Name = "dgwMusteri";
            this.dgwMusteri.RowHeadersWidth = 51;
            this.dgwMusteri.RowTemplate.Height = 24;
            this.dgwMusteri.Size = new System.Drawing.Size(650, 379);
            this.dgwMusteri.TabIndex = 13;
            this.dgwMusteri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteri_CellContentClick);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(682, 64);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(771, 379);
            this.dgvProduct.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "MüsteriSeçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ürün Seçin";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(182, 115);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(292, 24);
            this.cmbMusteri.TabIndex = 28;
            // 
            // cmbUrun
            // 
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(929, 115);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(300, 24);
            this.cmbUrun.TabIndex = 29;
            // 
            // btnUrunl
            // 
            this.btnUrunl.Location = new System.Drawing.Point(1126, 601);
            this.btnUrunl.Name = "btnUrunl";
            this.btnUrunl.Size = new System.Drawing.Size(327, 134);
            this.btnUrunl.TabIndex = 30;
            this.btnUrunl.Text = "ürünlere dön";
            this.btnUrunl.UseVisualStyleBackColor = true;
            this.btnUrunl.Click += new System.EventHandler(this.btnUrunl_Click);
            // 
            // SatisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1892, 885);
            this.Controls.Add(this.btnUrunl);
            this.Controls.Add(this.cmbUrun);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnGoProducts);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.dgwMusteri);
            this.Name = "SatisEkrani";
            this.Text = "SatisEkrani";
            this.Load += new System.EventHandler(this.SatisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnGoProducts;
        private System.Windows.Forms.DataGridView dgwMusteri;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.Button btnUrunl;
    }
}