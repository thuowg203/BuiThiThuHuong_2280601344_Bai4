namespace BuiThiThuHuong_2280601344_Bai4
{
    partial class Form2
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
            this.labMSNV = new System.Windows.Forms.Label();
            this.lblTenNv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDongy = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labMSNV
            // 
            this.labMSNV.AutoSize = true;
            this.labMSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMSNV.Location = new System.Drawing.Point(53, 47);
            this.labMSNV.Name = "labMSNV";
            this.labMSNV.Size = new System.Drawing.Size(77, 25);
            this.labMSNV.TabIndex = 0;
            this.labMSNV.Text = "MSNV:";
            // 
            // lblTenNv
            // 
            this.lblTenNv.AutoSize = true;
            this.lblTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNv.Location = new System.Drawing.Point(53, 118);
            this.lblTenNv.Name = "lblTenNv";
            this.lblTenNv.Size = new System.Drawing.Size(143, 25);
            this.lblTenNv.TabIndex = 1;
            this.lblTenNv.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lương căn bản:";
            // 
            // btnDongy
            // 
            this.btnDongy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongy.Location = new System.Drawing.Point(172, 313);
            this.btnDongy.Name = "btnDongy";
            this.btnDongy.Size = new System.Drawing.Size(115, 38);
            this.btnDongy.TabIndex = 3;
            this.btnDongy.Text = "Đồng ý";
            this.btnDongy.UseVisualStyleBackColor = true;
            this.btnDongy.Click += new System.EventHandler(this.btnDongy_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoqua.Location = new System.Drawing.Point(547, 313);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(115, 38);
            this.btnBoqua.TabIndex = 4;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(290, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(397, 22);
            this.txtID.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(290, 118);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(397, 22);
            this.txtTen.TabIndex = 6;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(290, 199);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(397, 22);
            this.txtLuong.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnDongy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTenNv);
            this.Controls.Add(this.labMSNV);
            this.Name = "Form2";
            this.Text = "Nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMSNV;
        private System.Windows.Forms.Label lblTenNv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDongy;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtLuong;
    }
}