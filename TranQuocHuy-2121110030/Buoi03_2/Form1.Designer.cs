
namespace Buoi03_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtHoTen = new System.Windows.Forms.MaskedTextBox();
            this.mxtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.mtxtMaSV = new System.Windows.Forms.MaskedTextBox();
            this.chbMuaSam = new System.Windows.Forms.CheckBox();
            this.chbDuLich = new System.Windows.Forms.CheckBox();
            this.chbTheThao = new System.Windows.Forms.CheckBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbShow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtHoTen);
            this.groupBox1.Controls.Add(this.mxtNgaySinh);
            this.groupBox1.Controls.Add(this.mtxtMaSV);
            this.groupBox1.Controls.Add(this.chbMuaSam);
            this.groupBox1.Controls.Add(this.chbDuLich);
            this.groupBox1.Controls.Add(this.chbTheThao);
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 471);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // mtxtHoTen
            // 
            this.mtxtHoTen.Location = new System.Drawing.Point(151, 101);
            this.mtxtHoTen.Name = "mtxtHoTen";
            this.mtxtHoTen.Size = new System.Drawing.Size(218, 22);
            this.mtxtHoTen.TabIndex = 12;
            // 
            // mxtNgaySinh
            // 
            this.mxtNgaySinh.Location = new System.Drawing.Point(151, 141);
            this.mxtNgaySinh.Mask = "00/00/0000";
            this.mxtNgaySinh.Name = "mxtNgaySinh";
            this.mxtNgaySinh.Size = new System.Drawing.Size(274, 22);
            this.mxtNgaySinh.TabIndex = 11;
            // 
            // mtxtMaSV
            // 
            this.mtxtMaSV.Location = new System.Drawing.Point(151, 53);
            this.mtxtMaSV.Mask = "2100000000";
            this.mtxtMaSV.Name = "mtxtMaSV";
            this.mtxtMaSV.Size = new System.Drawing.Size(274, 22);
            this.mtxtMaSV.TabIndex = 10;
            // 
            // chbMuaSam
            // 
            this.chbMuaSam.AutoSize = true;
            this.chbMuaSam.Location = new System.Drawing.Point(151, 299);
            this.chbMuaSam.Name = "chbMuaSam";
            this.chbMuaSam.Size = new System.Drawing.Size(87, 21);
            this.chbMuaSam.TabIndex = 9;
            this.chbMuaSam.Text = "Mua sắm";
            this.chbMuaSam.UseVisualStyleBackColor = true;
            // 
            // chbDuLich
            // 
            this.chbDuLich.AutoSize = true;
            this.chbDuLich.Location = new System.Drawing.Point(151, 272);
            this.chbDuLich.Name = "chbDuLich";
            this.chbDuLich.Size = new System.Drawing.Size(73, 21);
            this.chbDuLich.TabIndex = 8;
            this.chbDuLich.Text = "Du lịch";
            this.chbDuLich.UseVisualStyleBackColor = true;
            // 
            // chbTheThao
            // 
            this.chbTheThao.AutoSize = true;
            this.chbTheThao.Location = new System.Drawing.Point(151, 241);
            this.chbTheThao.Name = "chbTheThao";
            this.chbTheThao.Size = new System.Drawing.Size(92, 21);
            this.chbTheThao.TabIndex = 7;
            this.chbTheThao.Text = "Thể Thao";
            this.chbTheThao.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(322, 196);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(47, 21);
            this.rbNu.TabIndex = 6;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(151, 196);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(58, 21);
            this.rbNam.TabIndex = 5;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sở Thích";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh Vien";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(519, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(305, 53);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(153, 53);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 44);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 53);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(262, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông Tin Sinh Viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbShow);
            this.groupBox3.Location = new System.Drawing.Point(519, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 357);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách";
            // 
            // lbShow
            // 
            this.lbShow.AutoSize = true;
            this.lbShow.Location = new System.Drawing.Point(7, 32);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(40, 17);
            this.lbShow.TabIndex = 0;
            this.lbShow.Text = "none";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 607);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtHoTen;
        private System.Windows.Forms.MaskedTextBox mxtNgaySinh;
        private System.Windows.Forms.MaskedTextBox mtxtMaSV;
        private System.Windows.Forms.CheckBox chbMuaSam;
        private System.Windows.Forms.CheckBox chbDuLich;
        private System.Windows.Forms.CheckBox chbTheThao;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbShow;
    }
}

