
namespace Buoi03_1
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
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.lbSoA = new System.Windows.Forms.Label();
            this.lbSoB = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnHieu = new System.Windows.Forms.Button();
            this.btnTich = new System.Windows.Forms.Button();
            this.btnThuong = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoA
            // 
            this.txtSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoA.Location = new System.Drawing.Point(147, 114);
            this.txtSoA.Multiline = true;
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(671, 35);
            this.txtSoA.TabIndex = 0;
            // 
            // txtSoB
            // 
            this.txtSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoB.Location = new System.Drawing.Point(147, 196);
            this.txtSoB.Multiline = true;
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(671, 35);
            this.txtSoB.TabIndex = 1;
            // 
            // lbSoA
            // 
            this.lbSoA.AutoSize = true;
            this.lbSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoA.Location = new System.Drawing.Point(45, 124);
            this.lbSoA.Name = "lbSoA";
            this.lbSoA.Size = new System.Drawing.Size(42, 17);
            this.lbSoA.TabIndex = 2;
            this.lbSoA.Text = "Số A";
            // 
            // lbSoB
            // 
            this.lbSoB.AutoSize = true;
            this.lbSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoB.Location = new System.Drawing.Point(45, 206);
            this.lbSoB.Name = "lbSoB";
            this.lbSoB.Size = new System.Drawing.Size(42, 17);
            this.lbSoB.TabIndex = 3;
            this.lbSoB.Text = "Số B";
            // 
            // btnTong
            // 
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(56, 280);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(88, 39);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "Cộng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnHieu
            // 
            this.btnHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHieu.Location = new System.Drawing.Point(214, 280);
            this.btnHieu.Name = "btnHieu";
            this.btnHieu.Size = new System.Drawing.Size(88, 39);
            this.btnHieu.TabIndex = 5;
            this.btnHieu.Text = "Trừ";
            this.btnHieu.UseVisualStyleBackColor = true;
            this.btnHieu.Click += new System.EventHandler(this.btnHieu_Click);
            // 
            // btnTich
            // 
            this.btnTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTich.Location = new System.Drawing.Point(387, 280);
            this.btnTich.Name = "btnTich";
            this.btnTich.Size = new System.Drawing.Size(88, 39);
            this.btnTich.TabIndex = 6;
            this.btnTich.Text = "Nhân";
            this.btnTich.UseVisualStyleBackColor = true;
            this.btnTich.Click += new System.EventHandler(this.btnTich_Click);
            // 
            // btnThuong
            // 
            this.btnThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuong.Location = new System.Drawing.Point(555, 280);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(88, 39);
            this.btnThuong.TabIndex = 7;
            this.btnThuong.Text = "Chia";
            this.btnThuong.UseVisualStyleBackColor = true;
            this.btnThuong.Click += new System.EventHandler(this.btnThuong_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(710, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 39);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(45, 369);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(67, 17);
            this.lbKetQua.TabIndex = 9;
            this.lbKetQua.Text = "Kết Quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(147, 362);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(168, 32);
            this.txtKetQua.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(255, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chương Trình Tính Toán 2 Số";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThuong);
            this.Controls.Add(this.btnTich);
            this.Controls.Add(this.btnHieu);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.lbSoB);
            this.Controls.Add(this.lbSoA);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label lbSoA;
        private System.Windows.Forms.Label lbSoB;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnHieu;
        private System.Windows.Forms.Button btnTich;
        private System.Windows.Forms.Button btnThuong;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label1;
    }
}

