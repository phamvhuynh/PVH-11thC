/*
 * Created by SharpDevelop.
 * User: pham huynh
 * Date: 1/3/2019
 * Time: 8:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace bai6
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox ksngaytro;
		private System.Windows.Forms.TextBox ksloaiphongtro;
		private System.Windows.Forms.TextBox ksgiaphong;
		private System.Windows.Forms.TextBox hoten;
		private System.Windows.Forms.TextBox namsinh;
		private System.Windows.Forms.TextBox scmtnd;
		private System.Windows.Forms.DataGrid dtkhachsan;
		private System.Windows.Forms.Button nhaptt;
		private System.Windows.Forms.Button hienthi;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.ksngaytro = new System.Windows.Forms.TextBox();
			this.ksloaiphongtro = new System.Windows.Forms.TextBox();
			this.ksgiaphong = new System.Windows.Forms.TextBox();
			this.hoten = new System.Windows.Forms.TextBox();
			this.namsinh = new System.Windows.Forms.TextBox();
			this.scmtnd = new System.Windows.Forms.TextBox();
			this.dtkhachsan = new System.Windows.Forms.DataGrid();
			this.nhaptt = new System.Windows.Forms.Button();
			this.hienthi = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtkhachsan)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(23, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số ngày trọ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(23, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Loại phòng trọ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(23, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Gía phòng";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(23, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(233, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Thông Tin Cá Nhân";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(23, 122);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Họ và Tên";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(23, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Năm Sinh";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(23, 171);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(169, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Số Chứng Minh Thư Nhân Dân";
			// 
			// ksngaytro
			// 
			this.ksngaytro.Location = new System.Drawing.Point(130, 13);
			this.ksngaytro.Name = "ksngaytro";
			this.ksngaytro.Size = new System.Drawing.Size(121, 20);
			this.ksngaytro.TabIndex = 7;
			// 
			// ksloaiphongtro
			// 
			this.ksloaiphongtro.Location = new System.Drawing.Point(130, 40);
			this.ksloaiphongtro.Name = "ksloaiphongtro";
			this.ksloaiphongtro.Size = new System.Drawing.Size(121, 20);
			this.ksloaiphongtro.TabIndex = 8;
			// 
			// ksgiaphong
			// 
			this.ksgiaphong.Location = new System.Drawing.Point(130, 67);
			this.ksgiaphong.Name = "ksgiaphong";
			this.ksgiaphong.Size = new System.Drawing.Size(121, 20);
			this.ksgiaphong.TabIndex = 9;
			// 
			// hoten
			// 
			this.hoten.Location = new System.Drawing.Point(129, 119);
			this.hoten.Name = "hoten";
			this.hoten.Size = new System.Drawing.Size(127, 20);
			this.hoten.TabIndex = 10;
			// 
			// namsinh
			// 
			this.namsinh.Location = new System.Drawing.Point(130, 142);
			this.namsinh.Name = "namsinh";
			this.namsinh.Size = new System.Drawing.Size(121, 20);
			this.namsinh.TabIndex = 11;
			// 
			// scmtnd
			// 
			this.scmtnd.Location = new System.Drawing.Point(188, 168);
			this.scmtnd.Name = "scmtnd";
			this.scmtnd.Size = new System.Drawing.Size(147, 20);
			this.scmtnd.TabIndex = 12;
			// 
			// dtkhachsan
			// 
			this.dtkhachsan.DataMember = "";
			this.dtkhachsan.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dtkhachsan.Location = new System.Drawing.Point(23, 198);
			this.dtkhachsan.Name = "dtkhachsan";
			this.dtkhachsan.Size = new System.Drawing.Size(412, 126);
			this.dtkhachsan.TabIndex = 13;
			this.dtkhachsan.CurrentCellChanged += new System.EventHandler(this.DtkhachsanCurrentCellChanged);
			// 
			// nhaptt
			// 
			this.nhaptt.Location = new System.Drawing.Point(307, 35);
			this.nhaptt.Name = "nhaptt";
			this.nhaptt.Size = new System.Drawing.Size(114, 23);
			this.nhaptt.TabIndex = 14;
			this.nhaptt.Text = "Nhập thông tin";
			this.nhaptt.UseVisualStyleBackColor = true;
			this.nhaptt.Click += new System.EventHandler(this.NhapttClick);
			// 
			// hienthi
			// 
			this.hienthi.Location = new System.Drawing.Point(307, 90);
			this.hienthi.Name = "hienthi";
			this.hienthi.Size = new System.Drawing.Size(90, 23);
			this.hienthi.TabIndex = 15;
			this.hienthi.Text = "Hiển Thị";
			this.hienthi.UseVisualStyleBackColor = true;
			this.hienthi.Click += new System.EventHandler(this.HienthiClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 336);
			this.Controls.Add(this.hienthi);
			this.Controls.Add(this.nhaptt);
			this.Controls.Add(this.dtkhachsan);
			this.Controls.Add(this.scmtnd);
			this.Controls.Add(this.namsinh);
			this.Controls.Add(this.hoten);
			this.Controls.Add(this.ksgiaphong);
			this.Controls.Add(this.ksloaiphongtro);
			this.Controls.Add(this.ksngaytro);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "bai6";
			((System.ComponentModel.ISupportInitialize)(this.dtkhachsan)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
