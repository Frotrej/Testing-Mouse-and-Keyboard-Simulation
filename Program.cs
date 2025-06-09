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
Console.WriteLine("6 dla zapisania sekwencji myszy");
Console.WriteLine("7 pokaz zapisana sekwencje");
Console.WriteLine("0 Wyjscie\n\n");

ReadSaveAndSymulate readSaveAndSymulate = new();

int userChoice = 0;
do
{
	userChoice = int.TryParse(Console.ReadLine(), out int result) ? result : -1;

	KeyboardSimulation keyboardSimulation = new();
	MouseSimulation mouseSimulation = new();

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

			ReadingUserMouse.ShowMousePosition();

			Console.WriteLine("Zakonczono\n\n");

			break;

		case 5:
			Console.WriteLine("Opcja 5...");

			ReadingUserKeyStrokes.RecordAndDisplayKeys();

			Console.WriteLine("Zakonczono\n\n");

			break;

		case 6:
			Console.WriteLine("Opcja 6...");

			readSaveAndSymulate.SaveMousePositions();

			Console.WriteLine("Zakonczono\n\n");

			break;

		case 7:
			Console.WriteLine("Opcja 7...");

			Console.WriteLine("Zapisane pozycje:");
			foreach (var item in readSaveAndSymulate.mouseXYs)
			{
				Console.WriteLine($"X = {item.X}, Y = {item.Y}");
			}

			Console.WriteLine("Zakonczono\n\n");

			break;
	}
} while (userChoice != 0);

