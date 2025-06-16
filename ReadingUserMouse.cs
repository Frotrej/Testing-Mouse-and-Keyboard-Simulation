using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Mouse_and_Keyboard_Simulation
{

	internal class ReadingUserMouse()
	{

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool GetCursorPos(out POINT lpPoint);

		[StructLayout(LayoutKind.Sequential)]
		internal struct POINT
		{
			public int X;
			public int Y;
		}

		internal static void ShowMousePosition()
		{
			POINT point = new POINT();
			do
			{
				if (GetCursorPos(out point))
				{
					Console.WriteLine($"X = {point.X}, Y = {point.Y}");
				}
				else { Console.WriteLine("Blad pozycji"); }
			} while (point.X >= 5);
		}

		internal static POINT GetMousePosition()
		{
			POINT point = new();
			
			GetCursorPos(out point);
			
			return point;
		}

	}
}
