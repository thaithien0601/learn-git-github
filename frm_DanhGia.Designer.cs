namespace ThaiBaHung_0633_DACN
{
    partial class frm_DanhGia
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
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_tinhtien = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_vao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(103, 223);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(128, 27);
            this.btn_dong.TabIndex = 4;
            this.btn_dong.Text = "Close";
            this.btn_dong.UseVisualStyleBackColor = true;
            // 
            // btn_tinhtien
            // 
            this.btn_tinhtien.Location = new System.Drawing.Point(26, 175);
            this.btn_tinhtien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tinhtien.Name = "btn_tinhtien";
            this.btn_tinhtien.Size = new System.Drawing.Size(128, 27);
            this.btn_tinhtien.TabIndex = 3;
            this.btn_tinhtien.Text = "Delete";
            this.btn_tinhtien.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(176, 175);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(128, 27);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Turn off rating";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_dong);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.btn_tinhtien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.dt_vao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(583, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 277);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "View all";
            // 
            // dt_vao
            // 
            this.dt_vao.CustomFormat = "dd/MM/yyyy";
            this.dt_vao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_vao.Location = new System.Drawing.Point(112, 75);
            this.dt_vao.Margin = new System.Windows.Forms.Padding(4);
            this.dt_vao.Name = "dt_vao";
            this.dt_vao.Size = new System.Drawing.Size(192, 26);
            this.dt_vao.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evaluation management";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(112, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_hoadon.Location = new System.Drawing.Point(13, 48);
            this.dgv_hoadon.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.Size = new System.Drawing.Size(566, 277);
            this.dgv_hoadon.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Username";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Comment";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Rating";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Order";
            this.Column5.Name = "Column5";
            // 
            // DanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ThaiBaHung_0633_DACN.Properties.Resources.syed_hussaini_AUuOz9mQDYM_unsplash;
            this.ClientSize = new System.Drawing.Size(965, 362);
            this.Controls.Add(this.dgv_hoadon);
            this.Controls.Add(this.panel1);
            this.Name = "DanhGia";
            this.Text = "Evaluation management";
            this.Load += new System.EventHandler(this.DanhGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_tinhtien;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_vao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}