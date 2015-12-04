using System;
using System.Runtime.InteropServices;
using System.Drawing;

namespace STraF_U {
	/// <summary>
	/// Summary description for Win32.
	/// </summary>
	public class Win32 {
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern short GetKeyState(int nVirtKey);
	
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

		[DllImport("gdi32.dll", CharSet=CharSet.Auto)]
		public static extern bool ScreenToClient(IntPtr hWnd, Point point);
	}
}
