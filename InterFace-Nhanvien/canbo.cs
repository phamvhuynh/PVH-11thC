/*
 * Created by SharpDevelop.
 * User: pham huynh
 * Date: 12/20/2018
 * Time: 9:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace InterFace_Nhanvien
{
	/// <summary>
	/// Description of nhanvien.
	/// </summary>
	public class canbo
	{
		private string shoten;
		private string sdiachi;
		private string sgioitinh;
		private DateTime sngaysinh;
		public string hoten{
			get{return shoten;}
			set{
				shoten = value;
			}
		}
		public string diachi{
			get{
				return sdiachi;}
			set{
				sdiachi = value;}
		}
		public string gioitinh{
			get{
				return sgioitinh;
			}
			set{
				sgioitinh = value;
			}
	
		}
		public DateTime ngaysinh{
			get{
				return sngaysinh;
			}
			set{
				sngaysinh = value;
			}
		}
		public canbo()
		{
			shoten = "";
			sgioitinh = "";
			sdiachi = "";
			sngaysinh= DateTime.Now;
		}
	}
}
