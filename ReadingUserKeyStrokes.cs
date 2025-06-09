using SharpHook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Mouse_and_Keyboard_Simulation
{
	internal class ReadingUserKeyStrokes
	{

		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(int vKey);


		internal static void RecordAndDisplayKeys()
		{
			List<int> keys = new List<int>();

			Console.WriteLine("zacznij naciskac klawisze, program je przechwyci. \n");

			keys = GetPressedKeys();

			foreach (var item in keys)
			{
				Console.WriteLine($"ScanCode: {item}");
			}
		}

		internal static List<int> GetPressedKeys()
		{
			List<int> pressedKeys = new List<int>();

			int lastPressed = 0;
			do
			{
				for (int keyCode = 1; keyCode < 256; keyCode++)
				{
					//check if keycode is in range of 126 keyboard keys
					if ((GetAsyncKeyState(keyCode) & 0x8000) != 0 && keyCode > 0 && keyCode <= 126)
					{
						if (lastPressed != keyCode)
						{
							pressedKeys.Add(keyCode);
							lastPressed = keyCode;
							Console.WriteLine(keyCode);
						}
					}
				}
			} while (lastPressed != 81);
			return pressedKeys;
		}

		internal static bool IsSpacePressed()
		{
			bool pressed = false;
			int keyCode = 0;
			
			do
			{
				if ((GetAsyncKeyState(keyCode) & 0x8000) != 0 && keyCode == 61)
				{
					pressed = true;
				}
			} while(pressed != true);

			return pressed;
		}

		internal static bool IsEscapePressed()
		{
			bool pressed = false;
			int keyCode = 0;

			do
			{
				if ((GetAsyncKeyState(keyCode) & 0x8000) != 0 && keyCode == 110)
				{
					pressed = true;
				}
			} while (pressed != true);

			return pressed;
		}

	}
}
