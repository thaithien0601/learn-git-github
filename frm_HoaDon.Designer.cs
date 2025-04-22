namespace ThaiBaHung_0633_DACN
{
    partial class frm_HoaDon
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
            this.dt_vao = new System.Windows.Forms.DateTimePicker();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_tinhtien = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.cb_mon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_vao
            // 
            this.dt_vao.CustomFormat = "dd/MM/yyyy";
            this.dt_vao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_vao.Location = new System.Drawing.Point(112, 118);
            this.dt_vao.Margin = new System.Windows.Forms.Padding(4);
            this.dt_vao.Name = "dt_vao";
            this.dt_vao.Size = new System.Drawing.Size(192, 26);
            this.dt_vao.TabIndex = 7;
            // 
            // txt_mahd
            // 
            this.txt_mahd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mahd.Location = new System.Drawing.Point(112, 73);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(192, 26);
            this.txt_mahd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(176, 56);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(128, 27);
            this.btn_dong.TabIndex = 4;
            this.btn_dong.Text = "CLOSE";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_tinhtien
            // 
            this.btn_tinhtien.Location = new System.Drawing.Point(27, 21);
            this.btn_tinhtien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tinhtien.Name = "btn_tinhtien";
            this.btn_tinhtien.Size = new System.Drawing.Size(128, 27);
            this.btn_tinhtien.TabIndex = 3;
            this.btn_tinhtien.Text = "CREATE";
            this.btn_tinhtien.UseVisualStyleBackColor = true;
            this.btn_tinhtien.Click += new System.EventHandler(this.btn_chitiet_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(177, 21);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(128, 27);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "FIX";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_dong);
            this.panel3.Controls.Add(this.btn_tinhtien);
            this.panel3.Controls.Add(this.btn_sua);
            this.panel3.Controls.Add(this.btn_xoa);
            this.panel3.Location = new System.Drawing.Point(646, 370);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 106);
            this.panel3.TabIndex = 4;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(27, 55);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(128, 27);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "DELETE";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_hoadon);
            this.panel2.Location = new System.Drawing.Point(27, 77);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 399);
            this.panel2.TabIndex = 3;
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Location = new System.Drawing.Point(4, 4);
            this.dgv_hoadon.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.Size = new System.Drawing.Size(589, 395);
            this.dgv_hoadon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(122, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_sl);
            this.panel1.Controls.Add(this.cb_mon);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dt_vao);
            this.panel1.Controls.Add(this.txt_mahd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(646, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 272);
            this.panel1.TabIndex = 2;
            // 
            // txt_sl
            // 
            this.txt_sl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sl.Location = new System.Drawing.Point(112, 212);
            this.txt_sl.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(193, 26);
            this.txt_sl.TabIndex = 14;
            // 
            // cb_mon
            // 
            this.cb_mon.FormattingEnabled = true;
            this.cb_mon.Location = new System.Drawing.Point(112, 166);
            this.cb_mon.Margin = new System.Windows.Forms.Padding(4);
            this.cb_mon.Name = "cb_mon";
            this.cb_mon.Size = new System.Drawing.Size(192, 27);
            this.cb_mon.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number";
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ThaiBaHung_0633_DACN.Properties.Resources.maxime_lebrun_HqYWQo7l49w_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 548);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_HoaDon";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dt_vao;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_tinhtien;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.ComboBox cb_mon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}