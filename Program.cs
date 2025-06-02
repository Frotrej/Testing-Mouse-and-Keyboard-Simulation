using System;
using Testing_Mouse_and_Keyboard_Simulation;
//https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendinput
Console.WriteLine("Type a number:");
Console.WriteLine("1 dla myszy");
Console.WriteLine("2 dla klawiatury");
Console.WriteLine("3 dla skrotu klawiszowego");
Console.WriteLine("4 dal przykladu internetowego klikajacego \"wasd\" ");

int userChoice = 0;
do
{
	userChoice = Int32.Parse(Console.ReadLine());


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

			Console.WriteLine("Zakonczono\n\n");
			break;

		case 3:
			Console.WriteLine("Opcja 3...");

			Console.WriteLine("Zakonczono\n\n");
			break;

		case 4:
			Console.WriteLine("Opcja 4...");

			Thread.Sleep(2000);
			InternetExample example = new InternetExample();
			example.SendInputWithAPI();

			Console.WriteLine("Zakonczono\n\n");
			break;
	}
} while (userChoice != 0);