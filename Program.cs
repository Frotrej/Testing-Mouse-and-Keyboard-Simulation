using Testing_Mouse_and_Keyboard_Simulation;
//https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendinput
Console.WriteLine("Hello, World!");
Console.WriteLine("1 for Mouse");
Console.WriteLine("2 for Keyboard");



string userChoice = Console.ReadLine();
if (userChoice == "1")
{
	MouseWorking mouseWorking = new MouseWorking();
	mouseWorking.Start();

}
else if (userChoice == "2")
{

}