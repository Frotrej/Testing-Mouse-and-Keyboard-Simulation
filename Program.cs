using Testing_Mouse_and_Keyboard_Simulation;
//https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendinput
Console.WriteLine("Hello, World!");
Console.WriteLine("1 for Mouse");
Console.WriteLine("2 for Keyboard");
Console.WriteLine("3 for desktop shortcut");



string userChoice = Console.ReadLine();
if (userChoice == "1")
{
	MouseWorking mouseWorking = new MouseWorking();
	mouseWorking.Start();

}
else if (userChoice == "2")
{

}
else if (userChoice == "3")
{

}

switch (userChoice)
{
	case "1":
		Console.WriteLine("symulowanie myszy w toku...");
		MouseWorking mouseWorking = new MouseWorking();
		mouseWorking.Start();

		break;

	case "2":
		Console.WriteLine("Opcja 2...");
		break;

	case "3":
		Console.WriteLine("Symulowanie skrotu klawiaturowego...");
		KeyboardInputs keyboardInputs = new KeyboardInputs();
		keyboardInputs.DesktopShortcut();
		break;
}