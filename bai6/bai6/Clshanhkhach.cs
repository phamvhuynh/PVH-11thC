/*
 * Created by SharpDevelop.
 * User: pham huynh
 * Date: 1/3/2019
 * Time: 8:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace bai6
{
	/// <summary>
	/// Description of Clshanhkhach.
	/// </summary>
	public class Clshanhkhach
	{
		public string hoten{get;set;}
		public string CMTND{get;set;}
		public string namsinh{get;set;}
		public int tuoi{
			get{
				return(DateTime.Now.Year - namsinh);
			}
		}
		public Clshanhkhach()
		{
		}
	}
}
