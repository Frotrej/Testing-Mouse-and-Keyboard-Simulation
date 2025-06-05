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
			var pressedKeys = new List<int>();

			int lastPressed = 0;
			do
			{
				
				for (int keyCode = 1; keyCode < 256; keyCode++)
				{
					
					if (keyCode == 231 || keyCode == 241) continue;

					if ((GetAsyncKeyState(keyCode) & 0x8000) != 0)
					{
						if (lastPressed != keyCode){
							pressedKeys.Add(keyCode);
							lastPressed = keyCode;
							Console.WriteLine(keyCode);
						}

					}

				}

			} while (true);


			return pressedKeys;
		}

	}
}
