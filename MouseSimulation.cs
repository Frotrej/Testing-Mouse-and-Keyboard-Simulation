using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Testing_Mouse_and_Keyboard_Simulation.SendInputInplementation;

namespace Testing_Mouse_and_Keyboard_Simulation
{
	internal class MouseSimulation
	{

		[DllImport("user32.dll", SetLastError = true)]
		static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);


		internal void MyInputs()
		{
			INPUT[] Inputs = new INPUT[5];
			INPUT Input = new INPUT();

			Input.type = 0;
			Input.U.mi.dx = 10000;
			Input.U.mi.dy = 10000;
			Input.U.mi.dwFlags = MOUSEEVENTF.MOVE | MOUSEEVENTF.ABSOLUTE;
			Inputs[0] = Input;
			
			SendInput(1, Inputs, INPUT.Size);

			Thread.Sleep(1000);

			Input.type = 0;
			Input.U.mi.dx = 50000;
			Input.U.mi.dy = 50000;
			Input.U.mi.dwFlags = MOUSEEVENTF.MOVE | MOUSEEVENTF.ABSOLUTE;
			Inputs[0] = Input;

			SendInput(1, Inputs, INPUT.Size);

			Thread.Sleep(500);

			Input.type = 0;
			Input.U.mi.dwFlags = MOUSEEVENTF.LEFTDOWN;
			Inputs[0] = Input;

			Input.type = 0;
			Input.U.mi.dwFlags = MOUSEEVENTF.LEFTUP;
			Inputs[1] = Input;

			SendInput(2, Inputs, INPUT.Size);
		}
	}
}
