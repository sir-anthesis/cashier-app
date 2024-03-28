namespace CashierApp
{
    partial class FormPegawai
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
            this.txIdPg = new System.Windows.Forms.TextBox();
            this.txNamaPg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numUsia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.gvTbPg = new System.Windows.Forms.DataGridView();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txAlamat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txUsn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txPw = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUsia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTbPg)).BeginInit();
            this.SuspendLayout();
            // 
            // txIdPg
            // 
            this.txIdPg.Location = new System.Drawing.Point(152, 71);
            this.txIdPg.Name = "txIdPg";
            this.txIdPg.Size = new System.Drawing.Size(207, 20);
            this.txIdPg.TabIndex = 0;
            // 
            // txNamaPg
            // 
            this.txNamaPg.Location = new System.Drawing.Point(152, 109);
            this.txNamaPg.Name = "txNamaPg";
            this.txNamaPg.Size = new System.Drawing.Size(207, 20);
            this.txNamaPg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Pegawai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama Pegawai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gender";
            // 
            // numUsia
            // 
            this.numUsia.Location = new System.Drawing.Point(152, 247);
            this.numUsia.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUsia.Name = "numUsia";
            this.numUsia.Size = new System.Drawing.Size(207, 20);
            this.numUsia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Usia";
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
            this.btSimpan.Location = new System.Drawing.Point(61, 348);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(298, 32);
            this.btSimpan.TabIndex = 13;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(61, 386);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(298, 37);
            this.btUpdate.TabIndex = 14;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(61, 429);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(298, 31);
            this.btDelete.TabIndex = 15;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // gvTbPg
            // 
            this.gvTbPg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTbPg.Location = new System.Drawing.Point(388, 71);
            this.gvTbPg.Name = "gvTbPg";
            this.gvTbPg.Size = new System.Drawing.Size(382, 311);
            this.gvTbPg.TabIndex = 16;
            this.gvTbPg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTbPg_CellClick);
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.cbGender.Location = new System.Drawing.Point(152, 147);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(207, 21);
            this.cbGender.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 188);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Alamat";
            // 
            // txAlamat
            // 
            this.txAlamat.Location = new System.Drawing.Point(152, 185);
            this.txAlamat.Multiline = true;
            this.txAlamat.Name = "txAlamat";
            this.txAlamat.Size = new System.Drawing.Size(207, 45);
            this.txAlamat.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Username";
            // 
            // txUsn
            // 
            this.txUsn.Location = new System.Drawing.Point(152, 280);
            this.txUsn.Name = "txUsn";
            this.txUsn.Size = new System.Drawing.Size(207, 20);
            this.txUsn.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Password";
            // 
            // txPw
            // 
            this.txPw.Location = new System.Drawing.Point(152, 318);
            this.txPw.Name = "txPw";
            this.txPw.Size = new System.Drawing.Size(207, 20);
            this.txPw.TabIndex = 22;
            // 
            // FormPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 472);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txPw);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txUsn);
            this.Controls.Add(this.txAlamat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.gvTbPg);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numUsia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txNamaPg);
            this.Controls.Add(this.txIdPg);
            this.Name = "FormPegawai";
            this.Text = "FormPegawai";
            this.Load += new System.EventHandler(this.FormPegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUsia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTbPg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txIdPg;
        private System.Windows.Forms.TextBox txNamaPg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUsia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView gvTbPg;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txAlamat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txUsn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txPw;
    }
}