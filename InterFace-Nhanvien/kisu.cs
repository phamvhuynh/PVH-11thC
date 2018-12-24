/*
 * Created by SharpDevelop.
 * User: pham huynh
 * Date: 12/20/2018
 * Time: 9:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace InterFace_Nhanvien
{
	/// <summary>
	/// Description of kisu.
	/// </summary>
	public class kisu: canbo
	{
		private string snganhdt;
		
		public string nganhdt
		{
			get{
				return snganhdt;
			}
			set{
				snganhdt = value;
			}
			
		}
		public kisu()
		{
			
			snganhdt = "";
			
		}
	}
}
