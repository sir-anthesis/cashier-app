namespace CashierApp
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
            this.btopen = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbarang = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btopen
            // 
            this.btopen.Location = new System.Drawing.Point(12, 12);
            this.btopen.Name = "btopen";
            this.btopen.Size = new System.Drawing.Size(118, 23);
            this.btopen.TabIndex = 0;
            this.btopen.Text = "Open Connection";
            this.btopen.UseVisualStyleBackColor = true;
            this.btopen.Click += new System.EventHandler(this.btopen_Click);
            // 
            // btclose
            // 
            this.btclose.Location = new System.Drawing.Point(12, 55);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(118, 23);
            this.btclose.TabIndex = 1;
            this.btclose.Text = "Close Connection";
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Masukan ID Barang";
            // 
            // txbarang
            // 
            this.txbarang.Location = new System.Drawing.Point(88, 135);
            this.txbarang.Name = "txbarang";
            this.txbarang.Size = new System.Drawing.Size(100, 20);
            this.txbarang.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cari Barang";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbarang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btopen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btopen;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbarang;
        private System.Windows.Forms.Button button1;
    }
}

