namespace WindowsFormsApp4
{
    partial class admin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunubirlik = new System.Windows.Forms.Button();
            this.yurtici = new System.Windows.Forms.Button();
            this.yurtdisi = new System.Windows.Forms.Button();
            this.erkenrez = new System.Windows.Forms.Button();
            this.callcenter = new System.Windows.Forms.Label();
            this.callcenter2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btntur = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gunubirlik, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.yurtici, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.yurtdisi, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.erkenrez, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.callcenter, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.callcenter2, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 490);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Papyrus", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZEYDA TUR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gunubirlik
            // 
            this.gunubirlik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunubirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunubirlik.Location = new System.Drawing.Point(3, 84);
            this.gunubirlik.Name = "gunubirlik";
            this.gunubirlik.Size = new System.Drawing.Size(203, 75);
            this.gunubirlik.TabIndex = 1;
            this.gunubirlik.Text = "Günübirlik Turlar";
            this.gunubirlik.UseVisualStyleBackColor = true;
            this.gunubirlik.Click += new System.EventHandler(this.gunubirlik_Click);
            // 
            // yurtici
            // 
            this.yurtici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yurtici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yurtici.Location = new System.Drawing.Point(3, 165);
            this.yurtici.Name = "yurtici";
            this.yurtici.Size = new System.Drawing.Size(203, 75);
            this.yurtici.TabIndex = 2;
            this.yurtici.Text = "Yurtiçi Turlar";
            this.yurtici.UseVisualStyleBackColor = true;
            this.yurtici.Click += new System.EventHandler(this.yurtici_Click);
            // 
            // yurtdisi
            // 
            this.yurtdisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yurtdisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yurtdisi.Location = new System.Drawing.Point(3, 246);
            this.yurtdisi.Name = "yurtdisi";
            this.yurtdisi.Size = new System.Drawing.Size(203, 75);
            this.yurtdisi.TabIndex = 3;
            this.yurtdisi.Text = "Yurtdışı Turlar";
            this.yurtdisi.UseVisualStyleBackColor = true;
            this.yurtdisi.Click += new System.EventHandler(this.yurtdisi_Click);
            // 
            // erkenrez
            // 
            this.erkenrez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.erkenrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.erkenrez.Location = new System.Drawing.Point(3, 327);
            this.erkenrez.Name = "erkenrez";
            this.erkenrez.Size = new System.Drawing.Size(203, 75);
            this.erkenrez.TabIndex = 4;
            this.erkenrez.Text = "Erken Rezervasyon";
            this.erkenrez.UseVisualStyleBackColor = true;
            this.erkenrez.Click += new System.EventHandler(this.erkenrez_Click);
            // 
            // callcenter
            // 
            this.callcenter.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.callcenter, 2);
            this.callcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.callcenter.Font = new System.Drawing.Font("Papyrus", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callcenter.Location = new System.Drawing.Point(3, 405);
            this.callcenter.Name = "callcenter";
            this.callcenter.Size = new System.Drawing.Size(412, 85);
            this.callcenter.TabIndex = 5;
            this.callcenter.Text = "444 81 81";
            this.callcenter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // callcenter2
            // 
            this.callcenter2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.callcenter2, 2);
            this.callcenter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.callcenter2.Font = new System.Drawing.Font("Papyrus", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callcenter2.Location = new System.Drawing.Point(421, 405);
            this.callcenter2.Name = "callcenter2";
            this.callcenter2.Size = new System.Drawing.Size(413, 85);
            this.callcenter2.TabIndex = 6;
            this.callcenter2.Text = "/ ZEYDA TUR";
            this.callcenter2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(212, 84);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(622, 318);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btntur, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btniptal, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(616, 312);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btntur
            // 
            this.btntur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btntur.Location = new System.Drawing.Point(208, 81);
            this.btntur.Name = "btntur";
            this.btntur.Size = new System.Drawing.Size(199, 72);
            this.btntur.TabIndex = 0;
            this.btntur.Text = "Tur Düzenle";
            this.btntur.UseVisualStyleBackColor = true;
            this.btntur.Click += new System.EventHandler(this.button1_Click);
            // 
            // btniptal
            // 
            this.btniptal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btniptal.Location = new System.Drawing.Point(208, 159);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(199, 72);
            this.btniptal.TabIndex = 2;
            this.btniptal.Text = "Bilet İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "admin";
            this.Text = "admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gunubirlik;
        private System.Windows.Forms.Button yurtici;
        private System.Windows.Forms.Button yurtdisi;
        private System.Windows.Forms.Button erkenrez;
        private System.Windows.Forms.Label callcenter;
        private System.Windows.Forms.Label callcenter2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btntur;
        private System.Windows.Forms.Button btniptal;
    }
}