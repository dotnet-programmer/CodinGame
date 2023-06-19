using CodinGame;

Console.WriteLine("1. Easy");
Console.WriteLine("2. Medium");
Console.WriteLine("3. Hard");
Console.WriteLine("4. Very Hard");
Console.Write("Wybierz poziom: ");
int mainMenuNumber = int.Parse(Console.ReadLine());

Console.WriteLine("\nLista rozwiązanych problemów: ");
bool result = mainMenuNumber switch
{
	1 => EasyProblems(),
	2 => MediumProblems(),
	3 => HardProblems(),
	4 => VeryHardProblems(),
	_ => false
};

bool EasyProblems()
{
	Console.WriteLine("1. MIME Type");
	Console.WriteLine("2. Temperatures");
	Console.WriteLine("3. The Descent");
	Console.WriteLine("4. Mars_Lander_Episode_1");
	Console.WriteLine("5. ASCII Art");
	Console.WriteLine("6. Unary");
	Console.WriteLine("7. Lumen");
	Console.Write("Wybierz numer zadania: ");
	int menuNumber = int.Parse(Console.ReadLine());
	_ = menuNumber switch
	{
		1 => Easy.MIME_Type(),
		2 => Easy.Temperatures(),
		3 => Easy.The_Descent(),
		4 => Easy.Mars_Lander_Episode_1(),
		5 => Easy.ASCII_Art(),
		6 => Easy.Unary(),
		7 => Easy.Lumen(),
		_ => false,
	};
	return true;
}

bool MediumProblems()
{
	Console.WriteLine("1. ");
	Console.Write("Wybierz numer zadania: ");
	int menuNumber = int.Parse(Console.ReadLine());
	_ = menuNumber switch
	{
		_ => false,
	};
	return true;
}

bool HardProblems()
{
	Console.WriteLine("1. ");
	Console.Write("Wybierz numer zadania: ");
	int menuNumber = int.Parse(Console.ReadLine());
	_ = menuNumber switch
	{
		_ => false,
	};
	return true;
}

bool VeryHardProblems()
{
	Console.WriteLine("1. ");
	Console.Write("Wybierz numer zadania: ");
	int menuNumber = int.Parse(Console.ReadLine());
	_ = menuNumber switch
	{
		_ => false,
	};
	return true;
}