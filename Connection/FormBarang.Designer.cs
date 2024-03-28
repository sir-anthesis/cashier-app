namespace CashierApp
{
    partial class FormBarang
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
            this.txIdBr = new System.Windows.Forms.TextBox();
            this.txNamaBr = new System.Windows.Forms.TextBox();
            this.numHargaBr = new System.Windows.Forms.NumericUpDown();
            this.dtExBr = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numStBr = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.gvTbBr = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numHargaBr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStBr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTbBr)).BeginInit();
            this.SuspendLayout();
            // 
            // txIdBr
            // 
            this.txIdBr.Location = new System.Drawing.Point(152, 71);
            this.txIdBr.Name = "txIdBr";
            this.txIdBr.Size = new System.Drawing.Size(207, 20);
            this.txIdBr.TabIndex = 0;
            // 
            // txNamaBr
            // 
            this.txNamaBr.Location = new System.Drawing.Point(152, 109);
            this.txNamaBr.Name = "txNamaBr";
            this.txNamaBr.Size = new System.Drawing.Size(207, 20);
            this.txNamaBr.TabIndex = 1;
            // 
            // numHargaBr
            // 
            this.numHargaBr.Location = new System.Drawing.Point(152, 148);
            this.numHargaBr.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numHargaBr.Name = "numHargaBr";
            this.numHargaBr.Size = new System.Drawing.Size(207, 20);
            this.numHargaBr.TabIndex = 4;
            // 
            // dtExBr
            // 
            this.dtExBr.Location = new System.Drawing.Point(152, 189);
            this.dtExBr.Name = "dtExBr";
            this.dtExBr.Size = new System.Drawing.Size(207, 20);
            this.dtExBr.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Harga Barang";
            // 
            // numStBr
            // 
            this.numStBr.Location = new System.Drawing.Point(152, 229);
            this.numStBr.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numStBr.Name = "numStBr";
            this.numStBr.Size = new System.Drawing.Size(207, 20);
            this.numStBr.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Expired Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stock Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "FORM TABEL BARANG";
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(61, 270);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(298, 32);
            this.btSimpan.TabIndex = 13;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(61, 308);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(298, 37);
            this.btUpdate.TabIndex = 14;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(61, 351);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(298, 31);
            this.btDelete.TabIndex = 15;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // gvTbBr
            // 
            this.gvTbBr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTbBr.Location = new System.Drawing.Point(388, 71);
            this.gvTbBr.Name = "gvTbBr";
            this.gvTbBr.Size = new System.Drawing.Size(382, 311);
            this.gvTbBr.TabIndex = 16;
            this.gvTbBr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTbBr_CellClick);
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 405);
            this.Controls.Add(this.gvTbBr);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numStBr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtExBr);
            this.Controls.Add(this.numHargaBr);
            this.Controls.Add(this.txNamaBr);
            this.Controls.Add(this.txIdBr);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHargaBr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStBr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTbBr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txIdBr;
        private System.Windows.Forms.TextBox txNamaBr;
        private System.Windows.Forms.NumericUpDown numHargaBr;
        private System.Windows.Forms.DateTimePicker dtExBr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numStBr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView gvTbBr;
    }
}