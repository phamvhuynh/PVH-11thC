/*
 * Created by SharpDevelop.
 * User: pham huynh
 * Date: 12/20/2018
 * Time: 8:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace InterFace_Nhanvien
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
		private System.Windows.Forms.TextBox nvhoten;
		private System.Windows.Forms.DateTimePicker nvngaysinh;
		private System.Windows.Forms.RadioButton nvnam;
		private System.Windows.Forms.RadioButton nvnu;
		private System.Windows.Forms.TextBox nvdiachi;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox nvnganhdt;
		private System.Windows.Forms.TextBox nvcongviec;
		private System.Windows.Forms.TextBox nvbac;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGrid dtnhanvien;
		private System.Windows.Forms.RadioButton cbcongnhan;
		private System.Windows.Forms.RadioButton cbnhanvien;
		private System.Windows.Forms.RadioButton cbkisu;
		private System.Windows.Forms.Button cbadd;
		private System.Windows.Forms.Button cbclear;
		private System.Windows.Forms.Button cbtimkiem;
		
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
			this.nvhoten = new System.Windows.Forms.TextBox();
			this.nvngaysinh = new System.Windows.Forms.DateTimePicker();
			this.nvnam = new System.Windows.Forms.RadioButton();
			this.nvnu = new System.Windows.Forms.RadioButton();
			this.nvdiachi = new System.Windows.Forms.TextBox();
			this.nvnganhdt = new System.Windows.Forms.TextBox();
			this.nvcongviec = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.label9 = new System.Windows.Forms.Label();
			this.dtnhanvien = new System.Windows.Forms.DataGrid();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbnhanvien = new System.Windows.Forms.RadioButton();
			this.cbkisu = new System.Windows.Forms.RadioButton();
			this.cbcongnhan = new System.Windows.Forms.RadioButton();
			this.cbadd = new System.Windows.Forms.Button();
			this.cbclear = new System.Windows.Forms.Button();
			this.cbtimkiem = new System.Windows.Forms.Button();
			this.nvbac = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtnhanvien)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(233, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Họ Tên";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(233, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Năm Sinh";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(233, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Giới Tính";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(233, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Địa chỉ";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(3, 186);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Bậc Công Nhân";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(233, 189);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Ngành Đào Tạo";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(463, 186);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Công Việc";
			// 
			// nvhoten
			// 
			this.nvhoten.Location = new System.Drawing.Point(318, 49);
			this.nvhoten.Name = "nvhoten";
			this.nvhoten.Size = new System.Drawing.Size(133, 20);
			this.nvhoten.TabIndex = 1;
			// 
			// nvngaysinh
			// 
			this.nvngaysinh.Location = new System.Drawing.Point(318, 75);
			this.nvngaysinh.Name = "nvngaysinh";
			this.nvngaysinh.Size = new System.Drawing.Size(133, 20);
			this.nvngaysinh.TabIndex = 2;
			this.nvngaysinh.ValueChanged += new System.EventHandler(this.NvngaysinhValueChanged);
			// 
			// nvnam
			// 
			this.nvnam.Checked = true;
			this.nvnam.Location = new System.Drawing.Point(6, 10);
			this.nvnam.Name = "nvnam";
			this.nvnam.Size = new System.Drawing.Size(50, 24);
			this.nvnam.TabIndex = 0;
			this.nvnam.TabStop = true;
			this.nvnam.Text = "Nam";
			this.nvnam.UseVisualStyleBackColor = true;
			// 
			// nvnu
			// 
			this.nvnu.Location = new System.Drawing.Point(81, 10);
			this.nvnu.Name = "nvnu";
			this.nvnu.Size = new System.Drawing.Size(50, 24);
			this.nvnu.TabIndex = 1;
			this.nvnu.Text = "Nữ";
			this.nvnu.UseVisualStyleBackColor = true;
			// 
			// nvdiachi
			// 
			this.nvdiachi.Location = new System.Drawing.Point(314, 147);
			this.nvdiachi.Name = "nvdiachi";
			this.nvdiachi.Size = new System.Drawing.Size(133, 20);
			this.nvdiachi.TabIndex = 4;
			// 
			// nvnganhdt
			// 
			this.nvnganhdt.Location = new System.Drawing.Point(326, 189);
			this.nvnganhdt.Name = "nvnganhdt";
			this.nvnganhdt.Size = new System.Drawing.Size(131, 20);
			this.nvnganhdt.TabIndex = 6;
			// 
			// nvcongviec
			// 
			this.nvcongviec.Location = new System.Drawing.Point(545, 186);
			this.nvcongviec.Name = "nvcongviec";
			this.nvcongviec.Size = new System.Drawing.Size(134, 20);
			this.nvcongviec.TabIndex = 7;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.nvnu);
			this.groupBox1.Controls.Add(this.nvnam);
			this.groupBox1.Location = new System.Drawing.Point(314, 101);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(137, 40);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Controls.Add(this.radioButton4);
			this.groupBox2.Location = new System.Drawing.Point(220, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(137, 40);
			this.groupBox2.TabIndex = 35;
			this.groupBox2.TabStop = false;
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(81, 10);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(50, 24);
			this.radioButton3.TabIndex = 10;
			this.radioButton3.Text = "Nữ";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.Checked = true;
			this.radioButton4.Location = new System.Drawing.Point(6, 10);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(50, 24);
			this.radioButton4.TabIndex = 9;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Nam";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(139, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 23);
			this.label9.TabIndex = 34;
			this.label9.Text = "Giới Tính";
			// 
			// dtnhanvien
			// 
			this.dtnhanvien.DataMember = "";
			this.dtnhanvien.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dtnhanvien.Location = new System.Drawing.Point(12, 215);
			this.dtnhanvien.Name = "dtnhanvien";
			this.dtnhanvien.Size = new System.Drawing.Size(698, 99);
			this.dtnhanvien.TabIndex = 11;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cbnhanvien);
			this.groupBox3.Controls.Add(this.cbkisu);
			this.groupBox3.Controls.Add(this.cbcongnhan);
			this.groupBox3.Location = new System.Drawing.Point(29, 49);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(151, 111);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			// 
			// cbnhanvien
			// 
			this.cbnhanvien.Location = new System.Drawing.Point(16, 82);
			this.cbnhanvien.Name = "cbnhanvien";
			this.cbnhanvien.Size = new System.Drawing.Size(104, 24);
			this.cbnhanvien.TabIndex = 2;
			this.cbnhanvien.TabStop = true;
			this.cbnhanvien.Text = "Nhân Viên";
			this.cbnhanvien.UseVisualStyleBackColor = true;
			// 
			// cbkisu
			// 
			this.cbkisu.Location = new System.Drawing.Point(16, 51);
			this.cbkisu.Name = "cbkisu";
			this.cbkisu.Size = new System.Drawing.Size(104, 24);
			this.cbkisu.TabIndex = 1;
			this.cbkisu.TabStop = true;
			this.cbkisu.Text = "Kĩ Sư";
			this.cbkisu.UseVisualStyleBackColor = true;
			// 
			// cbcongnhan
			// 
			this.cbcongnhan.Location = new System.Drawing.Point(16, 20);
			this.cbcongnhan.Name = "cbcongnhan";
			this.cbcongnhan.Size = new System.Drawing.Size(104, 24);
			this.cbcongnhan.TabIndex = 0;
			this.cbcongnhan.TabStop = true;
			this.cbcongnhan.Text = "Công Nhân";
			this.cbcongnhan.UseVisualStyleBackColor = true;
			// 
			// cbadd
			// 
			this.cbadd.Location = new System.Drawing.Point(534, 49);
			this.cbadd.Name = "cbadd";
			this.cbadd.Size = new System.Drawing.Size(75, 23);
			this.cbadd.TabIndex = 8;
			this.cbadd.Text = "Add";
			this.cbadd.UseVisualStyleBackColor = true;
			this.cbadd.Click += new System.EventHandler(this.CbaddClick);
			// 
			// cbclear
			// 
			this.cbclear.Location = new System.Drawing.Point(534, 82);
			this.cbclear.Name = "cbclear";
			this.cbclear.Size = new System.Drawing.Size(75, 23);
			this.cbclear.TabIndex = 9;
			this.cbclear.Text = "Clear";
			this.cbclear.UseVisualStyleBackColor = true;
			this.cbclear.Click += new System.EventHandler(this.CbclearClick);
			// 
			// cbtimkiem
			// 
			this.cbtimkiem.Location = new System.Drawing.Point(534, 120);
			this.cbtimkiem.Name = "cbtimkiem";
			this.cbtimkiem.Size = new System.Drawing.Size(75, 23);
			this.cbtimkiem.TabIndex = 10;
			this.cbtimkiem.Text = "Tìm Kiếm";
			this.cbtimkiem.UseVisualStyleBackColor = true;
			// 
			// nvbac
			// 
			this.nvbac.Location = new System.Drawing.Point(93, 183);
			this.nvbac.Name = "nvbac";
			this.nvbac.Size = new System.Drawing.Size(100, 20);
			this.nvbac.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 317);
			this.Controls.Add(this.nvbac);
			this.Controls.Add(this.cbtimkiem);
			this.Controls.Add(this.cbclear);
			this.Controls.Add(this.cbadd);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.dtnhanvien);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.nvcongviec);
			this.Controls.Add(this.nvnganhdt);
			this.Controls.Add(this.nvdiachi);
			this.Controls.Add(this.nvngaysinh);
			this.Controls.Add(this.nvhoten);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "InterFace-Nhanvien";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtnhanvien)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
