namespace WindowsFormsApp4
{
    partial class gunubirlik
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
            this.gunubirlikk = new System.Windows.Forms.Button();
            this.yurtici = new System.Windows.Forms.Button();
            this.yurtdisi = new System.Windows.Forms.Button();
            this.erkenrez = new System.Windows.Forms.Button();
            this.callcenter = new System.Windows.Forms.Label();
            this.callcenter2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbltur1 = new System.Windows.Forms.Label();
            this.lbltur2 = new System.Windows.Forms.Label();
            this.lbltur3 = new System.Windows.Forms.Label();
            this.lbltur4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.gunubirlikk, 0, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 561);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(876, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZEYDA TUR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gunubirlikk
            // 
            this.gunubirlikk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunubirlikk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunubirlikk.Location = new System.Drawing.Point(3, 96);
            this.gunubirlikk.Name = "gunubirlikk";
            this.gunubirlikk.Size = new System.Drawing.Size(214, 87);
            this.gunubirlikk.TabIndex = 1;
            this.gunubirlikk.Text = "Günübirlik Turlar";
            this.gunubirlikk.UseVisualStyleBackColor = true;
            this.gunubirlikk.Click += new System.EventHandler(this.gunubirlikk_Click);
            // 
            // yurtici
            // 
            this.yurtici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yurtici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yurtici.Location = new System.Drawing.Point(3, 189);
            this.yurtici.Name = "yurtici";
            this.yurtici.Size = new System.Drawing.Size(214, 87);
            this.yurtici.TabIndex = 2;
            this.yurtici.Text = "Yurtiçi Turlar";
            this.yurtici.UseVisualStyleBackColor = true;
            this.yurtici.Click += new System.EventHandler(this.yurtici_Click);
            // 
            // yurtdisi
            // 
            this.yurtdisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yurtdisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yurtdisi.Location = new System.Drawing.Point(3, 282);
            this.yurtdisi.Name = "yurtdisi";
            this.yurtdisi.Size = new System.Drawing.Size(214, 87);
            this.yurtdisi.TabIndex = 3;
            this.yurtdisi.Text = "Yurtdışı Turlar";
            this.yurtdisi.UseVisualStyleBackColor = true;
            this.yurtdisi.Click += new System.EventHandler(this.yurtdisi_Click);
            // 
            // erkenrez
            // 
            this.erkenrez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.erkenrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.erkenrez.Location = new System.Drawing.Point(3, 375);
            this.erkenrez.Name = "erkenrez";
            this.erkenrez.Size = new System.Drawing.Size(214, 87);
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
            this.callcenter.Location = new System.Drawing.Point(3, 465);
            this.callcenter.Name = "callcenter";
            this.callcenter.Size = new System.Drawing.Size(434, 96);
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
            this.callcenter2.Location = new System.Drawing.Point(443, 465);
            this.callcenter2.Name = "callcenter2";
            this.callcenter2.Size = new System.Drawing.Size(436, 96);
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
            this.tableLayoutPanel2.Controls.Add(this.lbltur1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbltur2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbltur3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbltur4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(223, 96);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(656, 366);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // lbltur1
            // 
            this.lbltur1.AutoSize = true;
            this.lbltur1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltur1.Enabled = false;
            this.lbltur1.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltur1.Location = new System.Drawing.Point(3, 0);
            this.lbltur1.Name = "lbltur1";
            this.lbltur1.Size = new System.Drawing.Size(322, 183);
            this.lbltur1.TabIndex = 0;
            this.lbltur1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltur1.Click += new System.EventHandler(this.lbltur1_Click);
            // 
            // lbltur2
            // 
            this.lbltur2.AutoSize = true;
            this.lbltur2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltur2.Enabled = false;
            this.lbltur2.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltur2.Location = new System.Drawing.Point(331, 0);
            this.lbltur2.Name = "lbltur2";
            this.lbltur2.Size = new System.Drawing.Size(322, 183);
            this.lbltur2.TabIndex = 1;
            this.lbltur2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltur2.Click += new System.EventHandler(this.lbltur2_Click);
            // 
            // lbltur3
            // 
            this.lbltur3.AutoSize = true;
            this.lbltur3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltur3.Enabled = false;
            this.lbltur3.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltur3.Location = new System.Drawing.Point(3, 183);
            this.lbltur3.Name = "lbltur3";
            this.lbltur3.Size = new System.Drawing.Size(322, 183);
            this.lbltur3.TabIndex = 2;
            this.lbltur3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltur3.Click += new System.EventHandler(this.lbltur3_Click);
            // 
            // lbltur4
            // 
            this.lbltur4.AutoSize = true;
            this.lbltur4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltur4.Enabled = false;
            this.lbltur4.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltur4.Location = new System.Drawing.Point(331, 183);
            this.lbltur4.Name = "lbltur4";
            this.lbltur4.Size = new System.Drawing.Size(322, 183);
            this.lbltur4.TabIndex = 3;
            this.lbltur4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltur4.Click += new System.EventHandler(this.lbltur4_Click);
            // 
            // gunubirlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "gunubirlik";
            this.Text = "gunubirlik";
            this.Load += new System.EventHandler(this.gunubirlik_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gunubirlikk;
        private System.Windows.Forms.Button yurtici;
        private System.Windows.Forms.Button yurtdisi;
        private System.Windows.Forms.Button erkenrez;
        private System.Windows.Forms.Label callcenter;
        private System.Windows.Forms.Label callcenter2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbltur1;
        private System.Windows.Forms.Label lbltur2;
        private System.Windows.Forms.Label lbltur3;
        private System.Windows.Forms.Label lbltur4;
    }
}