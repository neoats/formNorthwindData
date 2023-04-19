
namespace RecapProject1
{
    partial class Form1
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
            this.gbxCategori = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCategori = new System.Windows.Forms.ComboBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategori.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCategori
            // 
            this.gbxCategori.Controls.Add(this.label1);
            this.gbxCategori.Controls.Add(this.cbxCategori);
            this.gbxCategori.Location = new System.Drawing.Point(12, 12);
            this.gbxCategori.Name = "gbxCategori";
            this.gbxCategori.Size = new System.Drawing.Size(744, 86);
            this.gbxCategori.TabIndex = 0;
            this.gbxCategori.TabStop = false;
            this.gbxCategori.Text = "Kategoriye Göre Listele";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori :";
            // 
            // cbxCategori
            // 
            this.cbxCategori.FormattingEnabled = true;
            this.cbxCategori.Location = new System.Drawing.Point(65, 23);
            this.cbxCategori.Name = "cbxCategori";
            this.cbxCategori.Size = new System.Drawing.Size(121, 21);
            this.cbxCategori.TabIndex = 1;
            this.cbxCategori.SelectedIndexChanged += new System.EventHandler(this.cbxCategori_SelectedIndexChanged);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(65, 19);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(121, 20);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.label2);
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Location = new System.Drawing.Point(12, 116);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(744, 80);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ürün İsmine Göre Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ara :";
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.Location = new System.Drawing.Point(12, 216);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwProduct.Size = new System.Drawing.Size(744, 150);
            this.dgwProduct.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 646);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCategori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategori.ResumeLayout(false);
            this.gbxCategori.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCategori;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwProduct;
    }
}

