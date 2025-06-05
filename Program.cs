using System;
using Testing_Mouse_and_Keyboard_Simulation;
//https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendinput
Console.WriteLine("Type a number:");
Console.WriteLine("1 dla myszy");
Console.WriteLine("2 dla klawiatury");
Console.WriteLine("3 dla skrotu klawiszowego");
Console.WriteLine("4 ... ");
Console.WriteLine("0 Wyjscie\n\n");

int userChoice = 0;
do
{
	userChoice = int.TryParse(Console.ReadLine(), out int result) ? result : -1;


	switch (userChoice)
	{
		case 1:
			Console.WriteLine("Opcja 1...");
			
			MouseWorking mouseWorking = new MouseWorking();
			mouseWorking.Start();
			
			Console.WriteLine("Zakonczono\n\n");
			break;

		case 2:
			Console.WriteLine("Opcja 2...");

			Thread.Sleep(2000);
			KeyboardInputs keyboardInputs = new KeyboardInputs();
			keyboardInputs.MyInputs();

			Console.WriteLine("Zakonczono\n\n");
			break;

		case 3:
			Console.WriteLine("Opcja 3...");

			Console.WriteLine("Zakonczono\n\n");
			break;

		case 4:
			Console.WriteLine("Opcja 4...");

			Console.WriteLine("Zakonczono\n\n");
			break;
	}
} while (userChoice != 0);