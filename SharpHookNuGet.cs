using SharpHook;
using SharpHook.Data;
using SharpHook.Native;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

internal class SharpHookNuGet
{
	private static List<char> userInput = new List<char>();

	static bool isRunning = false;
	internal static TaskPoolGlobalHook hook;

	internal static async void Test()

	{

		if (isRunning == true)
		{
			TestStop();
			return;
		}

		hook = new TaskPoolGlobalHook();
		hook.KeyTyped += OnKeyTyped;
		isRunning = true;
		await hook.RunAsync();
		
	}

	static void TestStop()
	{
		hook.Dispose();
		isRunning = false;
	}


	private static void OnKeyTyped(object? sender, KeyboardHookEventArgs e)
	{
		Console.WriteLine($"Typed key: {e.Data.KeyChar}");
		userInput.Add(e.Data.KeyChar);
	}

}
