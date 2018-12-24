/*
 * Created by SharpDevelop.
 * User: pham huynh
 * Date: 12/20/2018
 * Time: 8:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;

namespace InterFace_Nhanvien
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		canbo cb = new canbo();
		BindingSource source;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void ClearData()
		{
			this.nvhoten.Text = "";
			this.nvdiachi.Text = "";
			this.nvnganhdt.Text= "";
			this.nvcongviec.Text="";
			this.nvbac.Text ="";
			
		}
		void NvngaysinhValueChanged(object sender, EventArgs e)
		{
			cb.ngaysinh =  DateTime.Parse(nvngaysinh.Text);
		}
		void CbclearClick(object sender, EventArgs e)
		{
			ClearData();
		}
		void CbaddClick(object sender, EventArgs e)
		{	
			
			if(cbcongnhan.Checked == true)
			{
				congnhan cn = new congnhan();
				List<congnhan> dscongnhan = new List<congnhan>();
				cn.hoten = nvhoten.Text;
				cn.ngaysinh = DateTime.Parse(nvngaysinh.Text);
				if(nvnam.Checked == true)
				{
					cn.gioitinh = "nam";
				}
				if(nvnu.Checked == true)
				{
					cn.gioitinh = "nu";
				}
				cn.diachi = nvdiachi.Text;
				cn.bacnhanvien = nvbac.Text;
				BindingList<congnhan> bindingList = new BindingList<congnhan>(dscongnhan);
				source = new BindingSource(bindingList, null);
				dtnhanvien.DataSource = source;
				source.Add(cn);
				cn = new congnhan();
				ClearData();
			}
			if(cbkisu.Checked == true)
			{
				kisu ks = new kisu();
				List<kisu> dskisu = new List<kisu>();
				ks.hoten = nvhoten.Text;
				ks.ngaysinh = DateTime.Parse(nvngaysinh.Text);
				if(nvnam.Checked == true)
				{
					ks.gioitinh = "nam";
				}
				if(nvnu.Checked == true)
				{
					ks.gioitinh = "nu";
				}
				ks.diachi = nvdiachi.Text;
				ks.nganhdt = nvnganhdt.Text;
				BindingList<kisu> bindingList = new BindingList<kisu>(dskisu);
				source = new BindingSource(bindingList, null);
				dtnhanvien.DataSource = source;
				source.Add(ks);
				ks = new kisu();
				ClearData();
			}
			if(cbnhanvien.Checked == true)
			{
				nhanvien nv = new nhanvien();
				List<nhanvien> dsnhanvien = new List<nhanvien>();
				nv.hoten = nvhoten.Text;
				nv.ngaysinh = DateTime.Parse(nvngaysinh.Text);
				if(nvnam.Checked == true)
				{
					nv.gioitinh = "nam";
				}
				if(nvnu.Checked == true)
				{
					nv.gioitinh = "nu";
				}
				nv.diachi = nvdiachi.Text;
				nv.congviec = nvcongviec.Text;
				BindingList<nhanvien> bindingList = new BindingList<nhanvien>(dsnhanvien);
				source = new BindingSource(bindingList, null);
				dtnhanvien.DataSource = source;
				source.Add(nv);
				nv = new nhanvien();
				ClearData();
			}
		}
		
		
	}
}
