/*
 * Created by SharpDevelop.
 * User: pham huynh
 * Date: 12/20/2018
 * Time: 9:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace InterFace_Nhanvien
{
	/// <summary>
	/// Description of congnhan.
	/// </summary>
	public class congnhan:canbo
	{
		private string sbacnhanvien;
		
		public string bacnhanvien{
			get{
				return sbacnhanvien;
			}
			set{
				sbacnhanvien = value;
			}
		}
		
		public congnhan()
		{	

			sbacnhanvien = "";
		}
	}
}
