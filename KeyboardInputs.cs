using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Testing_Mouse_and_Keyboard_Simulation.SendInputInplementation;

namespace Testing_Mouse_and_Keyboard_Simulation
{
	public class KeyboardInputs
	{
		[DllImport("user32.dll", SetLastError = true)]
		static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);


		internal void MyInputs()
		{
			INPUT[] Inputs = new INPUT[10];
			INPUT Input = new INPUT();
			uint howManyInputs = 0;

			INPUT MyKey = new INPUT();
			MyKey.type = 1;
			MyKey.U.ki.wScan = ScanCodeShort.KEY_5;
			MyKey.U.ki.dwFlags = KEYEVENTF.SCANCODE;
			Inputs[howManyInputs] = MyKey;
			howManyInputs++;

			MyKey.type = 1;
			MyKey.U.ki.wScan = ScanCodeShort.KEY_A;
			MyKey.U.ki.dwFlags = KEYEVENTF.SCANCODE;
			Inputs[howManyInputs] = MyKey;
			howManyInputs++;

			MyKey.type = 1;
			MyKey.U.ki.wScan = ScanCodeShort.KEY_A;
			MyKey.U.ki.dwFlags = KEYEVENTF.UNICODE;
			Inputs[howManyInputs] = MyKey;
			howManyInputs++;



			SendInput(howManyInputs, Inputs, INPUT.Size);
		}




	}
}
