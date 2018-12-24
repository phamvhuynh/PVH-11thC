/*
 * Created by SharpDevelop.
 * User: pham huynh
 * Date: 12/20/2018
 * Time: 9:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace InterFace_Nhanvien
{
	/// <summary>
	/// Description of nhanvien.
	/// </summary>
	public class nhanvien:canbo
	{
		private string scongviec;
	
		public string congviec{
			get{return scongviec;
			}
			set{scongviec = value;}
		}
		public nhanvien()
		{	
			
			scongviec = "";
		}
	}
}
