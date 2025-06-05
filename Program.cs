using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Testing_Mouse_and_Keyboard_Simulation;
//https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendinput
Console.WriteLine("Type a number:");
Console.WriteLine("1 dla myszy");
Console.WriteLine("2 dla klawiatury");
Console.WriteLine("3 dla skrotu klawiszowego");
Console.WriteLine("4 dla czytania myszy uzytkownika ");
Console.WriteLine("5 dla czytania klawiszy uzytkownika ");
Console.WriteLine("0 Wyjscie\n\n");

int userChoice = 0;
do
{
	userChoice = int.TryParse(Console.ReadLine(), out int result) ? result : -1;

	KeyboardSimulation keyboardSimulation = new KeyboardSimulation();
	MouseSimulation mouseSimulation = new MouseSimulation();


	switch (userChoice)
	{
		case 1:
			Console.WriteLine("Opcja 1...");

			mouseSimulation = new MouseSimulation();
			mouseSimulation.MyInputs();

			Console.WriteLine("Zakonczono\n\n");
			break;

		case 2:
			Console.WriteLine("Opcja 2...");

			keyboardSimulation = new KeyboardSimulation();
			keyboardSimulation.MyInputs();

			Console.WriteLine("Zakonczono\n\n");
			break;

		case 3:
			Console.WriteLine("Opcja 3...");

			keyboardSimulation = new KeyboardSimulation();
			keyboardSimulation.ShortcutToDesktop();

			Console.WriteLine("Zakonczono\n\n");
			break;

		case 4:
			Console.WriteLine("Opcja 4...");

			ReadingUserMouse.GetMousePosition();

			Console.WriteLine("Zakonczono\n\n");

			break;

		case 5:
			Console.WriteLine("Opcja 5...");

			ReadingUserKeyStrokes.RecordAndDisplayKeys();

			Console.WriteLine("Zakonczono\n\n");

			break;
	}
} while (userChoice != 0);

