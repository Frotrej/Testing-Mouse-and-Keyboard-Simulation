using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Testing_Mouse_and_Keyboard_Simulation.SendInputInplementation;

namespace Testing_Mouse_and_Keyboard_Simulation
{
	public class KeyboardSimulation
	{
		[DllImport("user32.dll", SetLastError = true)]
		static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);


		internal void MyInputs()
		{
			INPUT[] Inputs = new INPUT[50];
			INPUT Input = new INPUT();
			uint howManyInputs = 0;


			Input.type = 1;
			Input.U.ki.wScan = ScanCodeShort.KEY_D;
			Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
			Inputs[howManyInputs] = Input;
			howManyInputs++;

			Input.type = 1;
			Input.U.ki.wScan = ScanCodeShort.KEY_U;
			Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
			Inputs[howManyInputs] = Input;
			howManyInputs++;

			Input.type = 1;
			Input.U.ki.wScan = ScanCodeShort.KEY_P;
			Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
			Inputs[howManyInputs] = Input;
			howManyInputs++;


			SendInput(howManyInputs, Inputs, INPUT.Size);
		}



		internal void ShortcutToDesktop()
		{
			INPUT[] Inputs = new INPUT[5];
			INPUT Input = new INPUT();
			uint howManyInputs = 0;

			Input.type = 1;
			Input.U.ki.wVk = VirtualKeyShort.LWIN;
			Inputs[howManyInputs] = Input;
			howManyInputs++;

			Input.type = 1;
			Input.U.ki.wScan = ScanCodeShort.KEY_D;
			Input.U.ki.dwFlags = KEYEVENTF.SCANCODE;
			Inputs[howManyInputs] = Input;
			howManyInputs++;

			Input.type = 1;
			Input.U.ki.wVk = VirtualKeyShort.LWIN;
			Input.U.ki.dwFlags = KEYEVENTF.KEYUP;
			Inputs[howManyInputs] = Input;
			howManyInputs++;

			SendInput(howManyInputs, Inputs, INPUT.Size);
		}

	}
}
