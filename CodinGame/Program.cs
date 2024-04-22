using System.Reflection;
using CodinGame;

Console.ForegroundColor = ConsoleColor.Green;

Action[] _easy = 
	typeof(Easy)
	.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _medium = 
	typeof(Medium)
	.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _hard = 
	typeof(Hard)
	.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _veryHard = 
	typeof(VeryHard)
	.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

string[] menuItems = ["Easy", "Medium", "Hard", "Very Hard"];

while (true)
{
	ShowMenuPositions(menuItems);
	Console.Write("Choose a number: ");
	char keyChar = Console.ReadKey(true).KeyChar;
	switch (keyChar)
	{
		case '1':
			DoWork(_easy);
			break;
		case '2':
			DoWork(_medium);
			break;
		case '3':
			DoWork(_hard);
			break;
		case '4':
			DoWork(_veryHard);
			break;
		default:
			return;
	}
}

static void ShowMenuPositions(string[] menuItems)
{
	Console.Clear();
	for (int i = 0; i < menuItems.Length; i++)
	{
		Console.WriteLine($"{i + 1}. {menuItems[i]}");
	}
}

static void DoWork(Action[] functions, string header = "")
{
	bool isWorking = true;
	while (isWorking)
	{
		ShowMenuPositions(functions, header);
		Console.Write("Choose a number: ");
		isWorking = ExecuteMethod(Console.ReadLine(), functions);
	}

	static void ShowMenuPositions(Action[] functions, string header)
	{
		Console.Clear();

		if (!string.IsNullOrEmpty(header))
		{
			Console.WriteLine(header);
		}

		for (int i = 0; i < functions.Length; i++)
		{
			Console.WriteLine($"{i + 1}. {functions[i].Method.Name}");
		}
	}

	static bool ExecuteMethod(string input, Action[] functions)
	{
		if (int.TryParse(input, out int menuNumber) && menuNumber > 0 && menuNumber <= functions.Length)
		{
			functions[menuNumber - 1]();
			Console.ReadLine();
			return true;
		}
		else
		{
			return false;
		}
	}
}