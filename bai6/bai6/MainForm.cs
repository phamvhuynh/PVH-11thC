
/*
 * Created by SharpDevelop.
 * User: pham huynh
 * Date: 1/3/2019
 * Time: 8:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace bai6
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Clskhachsan ks = new Clskhachsan();
		List<Clskhachsan> ds = new List<Clskhachsan>();
		Clshanhkhach hanhkhach = new Clshanhkhach();
		List<Clshanhkhach> dshanhkhach = new List<Clshanhkhach>();
		BindingList<Clskhachsan> bindingList;
		BindingSource source;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			bindingList = new BindingList<Clskhachsan>(ds);
			source = new BindingSource(bindingList, null);
			dtkhachsan.DataSource = source;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void cleardata(){
			ksgiaphong.Text= "";
			ksngaytro.Text = "";
			ksloaiphongtro.Text= "";
			hoten.Text  = "";
			namsinh.Text = "";
			scmtnd.Text = "";
		}
		void NhapttClick(object sender, EventArgs e)
		{
			ks.giaphg = ksgiaphong.Text;
			ks.snt = ksngaytro.Text;
			ks.lpt = ksloaiphongtro.Text;
			ks.hoten = hoten.Text;
			ks.CMTND = scmtnd.Text;
			ks.namsinh = namsinh.Text;
			source.Add(ks);
			ks = new Clskhachsan();
			cleardata();
			dtkhachsan.Refresh();
		}
		void HienthiClick(object sender, EventArgs e)
		{
			BindingList<Clshanhkhach> Sort = new BindingList<Clshanhkhach>(dshanhkhach);
			BindingSource sortClick = new BindingSource(bindingList, null);
			dtkhachsan.DataSource = sortClick;
		}
		
		public void showdata(Clskhachsan ks){
			hoten.Text = ks.hoten;
			ksngaytro.Text = ks.snt;
			ksloaiphongtro.Text = ks.lpt;
			ksgiaphong.Text = ks.giaphg;
			scmtnd.Text = ks.CMTND;
			namsinh.Text = ks.namsinh;
		}
		void DtkhachsanCurrentCellChanged(object sender, EventArgs e)
		{
			try
			{
				var row = source[dtkhachsan.CurrentRowIndex];
				if(row != null)
				{
					var currentThiSinh = (Clskhachsan)row;
					showdata(currentThiSinh);
				}
			}catch
			{
				
			}
		}

	}
}
