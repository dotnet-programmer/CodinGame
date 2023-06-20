using System.Text;

namespace CodinGame;

public static class Easy
{
	public static void MIME_Type()
	{
		int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
		int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
		Dictionary<string, string> fileExtensions = new();
		for (int i = 0; i < N; i++)
		{
			string[] inputs = Console.ReadLine().Split(' ');
			fileExtensions[$".{inputs[0].ToLower()}"] = inputs[1];
		}
		for (int i = 0; i < Q; i++)
		{
			Console.WriteLine(fileExtensions.GetValueOrDefault(Path.GetExtension(Console.ReadLine().ToLower())) ?? "UNKNOWN");
		}

		#region First version
		//int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
		//int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
		//Dictionary<string, string> fileExtensions = new Dictionary<string, string>();
		//for (int i = 0; i < N; i++)
		//{
		//	string[] inputs = Console.ReadLine().Split(' ');
		//	string EXT = inputs[0].ToLower(); // file extension
		//	string MT = inputs[1]; // MIME type.
		//	if (!fileExtensions.ContainsKey(EXT))
		//	{
		//		fileExtensions.Add(EXT, MT);
		//	}
		//}
		//List<string> files = new List<string>();
		//for (int i = 0; i < Q; i++)
		//{
		//	string FNAME = Console.ReadLine(); // One file name per line.
		//	string ext = "UNKNOWN";
		//	if (FNAME.Contains('.'))
		//	{
		//		int index = FNAME.LastIndexOf(".");
		//		if (index != FNAME.Length - 1)
		//		{
		//			ext = FNAME.Substring(index + 1).ToLower();
		//		}
		//	}
		//	files.Add(ext);
		//}
		//foreach (var item in files)
		//{
		//	Console.WriteLine(fileExtensions.ContainsKey(item) ? fileExtensions[item] : "UNKNOWN");
		//}
		#endregion First version

		#region version with HashTable
		//static void Main(string[] args)
		//{
		//	var lookupHash = new Hashtable();
		//	int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
		//	int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
		//	for (int i = 0; i < N; i++)
		//	{
		//		string[] inputs = Console.ReadLine().Split(' ');
		//		string EXT = $".{inputs[0]}"; // file extension
		//		string MT = inputs[1]; // MIME type.
		//		if (!lookupHash.ContainsKey(EXT.ToLower()))
		//		{
		//			lookupHash.Add(EXT.ToLower(), MT);
		//		}
		//	}
		//	for (int i = 0; i < Q; i++)
		//	{
		//		string FNAME = Console.ReadLine(); // One file name per line.
		//		var output = "UNKNOWN";
		//		var ext = Path.GetExtension(FNAME).ToLower();
		//		Console.WriteLine(lookupHash[ext]?.ToString() ?? "UNKNOWN");
		//	}
		//}
		#endregion version with HashTable

		#region version with loop without List
		//static void Main(string[] args)
		//{
		//	Dictionary<string, string> fileTypes = new Dictionary<string, string>();
		//	int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
		//	int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
		//	for (int i = 0; i < N; i++)
		//	{
		//		string[] inputs = Console.ReadLine().Split(' ');
		//		string EXT = inputs[0].ToLower(); // file extension
		//		string MT = inputs[1]; // MIME type.
		//		fileTypes[EXT] = MT;
		//	}
		//	for (int i = 0; i < Q; i++)
		//	{
		//		string FNAME = Console.ReadLine(); // One file name per line.
		//		int extIndex = FNAME.LastIndexOf('.');
		//		if (extIndex > -1)
		//		{
		//			string ext = FNAME.Substring(extIndex + 1).ToLower();
		//			if (fileTypes.ContainsKey(ext))
		//			{
		//				Console.WriteLine(fileTypes[ext]);
		//				continue;
		//			}
		//		}
		//		Console.WriteLine("UNKNOWN");
		//	}
		//	Console.ReadLine();
		//}
		#endregion version with loop without List

		#region version with List<string>
		//static void Main(string[] args)
		//{
		//	Dictionary<string, string> fileTypes = new Dictionary<string, string>();
		//	int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
		//	int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
		//	for (int i = 0; i < N; i++)
		//	{
		//		string[] inputs = Console.ReadLine().Split(' ');
		//		string EXT = inputs[0].ToLower(); // file extension
		//		string MT = inputs[1]; // MIME type.
		//		fileTypes[EXT] = MT;
		//	}
		//List<string> files = new List<string>();
		//for (int i = 0; i < Q; i++)
		//{
		//	files.Add(Console.ReadLine());
		//}
		//for (int i = 0; i < files.Count; i++)
		//{
		//	int extIndex = files[i].LastIndexOf('.');
		//	if (extIndex > -1)
		//	{
		//		string ext = files[i].Substring(extIndex + 1).ToLower();
		//		if (fileTypes.ContainsKey(ext))
		//		{
		//			Console.WriteLine(fileTypes[ext]);
		//			continue;
		//		}
		//	}
		//	Console.WriteLine("UNKNOWN");
		//}
		//	Console.ReadLine();
		//}
		#endregion version with List<string>

		#region version with List<string>
		//int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
		//int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
		//Dictionary<string, string> fileExtensions = new();
		//for (int i = 0; i < N; i++)
		//{
		//	string[] inputs = Console.ReadLine().Split(' ');
		//	fileExtensions[$".{inputs[0].ToLower()}"] = inputs[1];
		//}
		//List<string> files = new();
		//for (int i = 0; i < Q; i++)
		//{
		//	files.Add(fileExtensions.GetValueOrDefault(Path.GetExtension(Console.ReadLine().ToLower())) ?? "UNKNOWN");
		//}
		//foreach (var item in files)
		//{
		//	Console.WriteLine(item);
		//}
		#endregion version with List<string>
	}

	public static void Temperatures()
	{
		if (int.Parse(Console.ReadLine()) != 0) // the number of temperatures to analyze
		{
			int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int min = inputs.Min(Math.Abs);
			Console.WriteLine(inputs.Contains(min) ? min : -min);
		}
		else
		{
			Console.WriteLine(0);
		}

		#region first version
		//int numberOfTemperatures = int.Parse(Console.ReadLine()); // the number of temperatures to analyze
		//int closestToZero = 0;
		//string[] inputs = Console.ReadLine().Split(' ');
		//for (int i = 0; i < numberOfTemperatures; i++)
		//{
		//	if (i == 0)
		//	{
		//		closestToZero = int.Parse(inputs[i]);
		//	}
		//	else
		//	{
		//		if (Math.Abs(int.Parse(inputs[i])) < Math.Abs(closestToZero))
		//		{
		//			closestToZero = int.Parse(inputs[i]);
		//		}
		//		else if (Math.Abs(int.Parse(inputs[i])) == Math.Abs(closestToZero))
		//		{
		//			if (int.Parse(inputs[i]) > 0)
		//			{
		//				closestToZero = int.Parse(inputs[i]);
		//			}
		//		}
		//	}
		//}
		//Console.WriteLine(closestToZero);
		#endregion first version

		#region second version
		//int closestToZero = 0;
		//if (int.Parse(Console.ReadLine()) != 0) // the number of temperatures to analyze
		//{
		//	int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		//	for (int i = 0; i < inputs.Length; i++)
		//	{
		//		if (i == 0)
		//		{
		//			closestToZero = inputs[i];
		//		}
		//		else
		//		{
		//			if (Math.Abs(inputs[i]) < Math.Abs(closestToZero))
		//			{
		//				closestToZero = inputs[i];
		//			}
		//			else if (Math.Abs(inputs[i]) == Math.Abs(closestToZero))
		//			{
		//				if (inputs[i] > 0)
		//				{
		//					closestToZero = inputs[i];
		//				}
		//			}
		//		}
		//	}
		//}
		//Console.WriteLine(closestToZero);
		#endregion second version

		#region using Aggregate
		//int n = int.Parse(Console.ReadLine());
		//var temps = Console.ReadLine().Split(' ').Take(n).Select(int.Parse);
		//Console.WriteLine(n == 0 ? 0 : temps.Aggregate(int.MaxValue, (min, temp) => Math.Abs(temp) < Math.Abs(min) || temp == -min && temp > 0 ? temp : min));
		#endregion using Aggregate
	}

	public static void The_Descent()
	{
		int[] collection = new int[8];
		while (true)
		{
			for (int i = 0; i < 8; i++)
			{
				collection[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine(Array.IndexOf(collection, collection.Max()));
		}

		#region version with List<>
		//List<int> inputs = new();
		//while (true)
		//{
		//	for (int i = 0; i < 8; i++)
		//	{
		//		inputs.Add(int.Parse(Console.ReadLine()));
		//	}
		//	Console.WriteLine(inputs.IndexOf(inputs.Max()));
		//	inputs.Clear();
		//}
		#endregion version with List<>
	}

	public static void Mars_Lander_Episode_1()
	{
		int[] inputs;
		int surfaceN = int.Parse(Console.ReadLine()); // the number of points used to draw the surface of Mars.
		for (int i = 0; i < surfaceN; i++)
		{
			inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int landX = inputs[0]; // X coordinate of a surface point. (0 to 6999)
			int landY = inputs[1]; // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
		}
		while (true)
		{
			inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int X = inputs[0];
			int Y = inputs[1];
			int hSpeed = inputs[2]; // the horizontal speed (in m/s), can be negative.
			int vSpeed = inputs[3]; // the vertical speed (in m/s), can be negative.
			int fuel = inputs[4]; // the quantity of remaining fuel in liters.
			int rotate = inputs[5]; // the rotation angle in degrees (-90 to 90).
			int power = inputs[6]; // the thrust power (0 to 4).
			if (vSpeed < -39)
			{
				if (power < 4)
				{
					power++;
				}
			}
			else if (power > 0)
			{
				power--;
			}
			Console.WriteLine($"0 {power}");
		}
	}

	public static void ASCII_Art()
	{
		int width = int.Parse(Console.ReadLine());
		int height = int.Parse(Console.ReadLine());
		string text = Console.ReadLine().ToUpper();

		string[] letters = new string[height];
		for (int i = 0; i < height; i++)
		{
			letters[i] = Console.ReadLine();
		}

		//letters[0] = " #  ##   ## ##  ### ###  ## # # ###  ## # # #   # # ###  #  ##   #  ##   ## ### # # # # # # # # # # ### ### ";
		//letters[1] = "# # # # #   # # #   #   #   # #  #    # # # #   ### # # # # # # # # # # #    #  # # # # # # # # # #   #   # ";
		//letters[2] = "### ##  #   # # ##  ##  # # ###  #    # ##  #   ### # # # # ##  # # ##   #   #  # # # # ###  #   #   #   ## ";
		//letters[3] = "# # # # #   # # #   #   # # # #  #  # # # # #   # # # # # # #    ## # #   #  #  # # # # ### # #  #  #       ";
		//letters[4] = "# # ##   ## ##  ### #    ## # # ###  #  # # ### # # # #  #  #     # # # ##   #  ###  #  # # # #  #  ###  #  ";

		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < text.Length; j++)
			{
				int position = (text[j] is >= 'A' and <= 'Z') ? (text[j] - 'A') : ('Z' - 'A' + 1);
				Console.Write(letters[i].Substring(position * width, width));
			}
			Console.WriteLine();
		}
	}

	public static void Unary()
	{
		string message = string.Empty;
		foreach (char c in Console.ReadLine())
		{
			message += Convert.ToString(c, 2).PadLeft(7, '0');
		}
		int count = 0;
		StringBuilder result = new();
		for (int i = 0; i < message.Length; i++)
		{
			char actualChar = message[i];
			count++;
			if (i < message.Length - 1 && actualChar == message[i + 1])
			{
				continue;
			}
			result.Append(actualChar == '1' ? "0 " : "00 ");
			while (count > 0)
			{
				result.Append('0');
				count--;
			}
			result.Append(' ');
		}
		Console.WriteLine(result.ToString().TrimEnd());

		#region version with Queue
		//string message = Console.ReadLine();
		//string binary = string.Empty;
		//for (int i = 0; i < message.Length; i++)
		//{
		//	binary += message[i] > 'A' ? Convert.ToString(message[i], 2) : "0" + Convert.ToString(message[i], 2);
		//}
		//Queue<char> binaryFull = new Queue<char>();
		//for (int i = 0; i < binary.Length; i++)
		//{
		//	binaryFull.Enqueue(binary[i]);
		//}
		//int count = 0;
		//string result = string.Empty;
		//while (binaryFull.Count > 0)
		//{
		//	char actualChar = binaryFull.Dequeue();
		//	count++;
		//	if (binaryFull.Count > 0 && actualChar == binaryFull.Peek())
		//		continue;
		//	result += actualChar == '1' ? "0 " : "00 ";
		//	while (count > 0)
		//	{
		//		result += "0";
		//		count--;
		//	}
		//	result += " ";
		//}
		//Console.WriteLine(result.Trim());
		//Console.ReadLine();
		#endregion version with Queue

		#region version with Regex
		//string MESSAGE = Console.ReadLine();
		//string encode = MESSAGE.Select(x => (int)x)
		//	.Select(x => Convert.ToString(x, 2).PadLeft(7, '0'))
		//	.Aggregate((x, y) => x + y);
		//encode = Regex.Replace(encode, @"(0+)", "00 $1 ");
		//encode = Regex.Replace(encode, @"(1+)", "0 $1 ").Replace("1", "0");
		//Console.WriteLine(encode.TrimEnd());
		#endregion version with Regex
	}

	public static void Lumen()
	{
		int size = int.Parse(Console.ReadLine());
		int light = int.Parse(Console.ReadLine());
		int[,] lights = new int[size, size];
		for (int i = 0; i < size; i++)
		{
			string[] inputs = Console.ReadLine().Split(' ');
			for (int j = 0; j < size; j++)
			{
				if (inputs[j] == "C")
				{
					for (int row = Math.Max(0, i - (light - 1)); row < Math.Min(size, i + light); row++)
					{
						for (int col = Math.Max(0, j - (light - 1)); col < Math.Min(size, j + light); col++)
						{
							lights[row, col]++;
						}
					}
				}
			}
		}
		int sum = 0;
		foreach (var item in lights)
		{
			if (item == 0)
			{
				sum++;
			}
		}
		Console.WriteLine(sum);
	}

	public static void Sudoku_Validator()
	{
		List<string>[] bigGrid = new List<string>[9];
		List<string>[] smallGrids = new List<string>[9];
		for (int i = 0; i < 9; i++)
		{
			bigGrid[i] = Console.ReadLine().Split(' ').ToList();
			smallGrids[i] = new List<string>(9);
		}
		//make smallGrids
		int skip = 0;
		for (int i = 0; i < 9; i++)
		{
			if (i > 0 && i % 3 == 0)
			{
				skip += 3;
			}
			for (int j = 0; j < 3; j++)
			{
				smallGrids[i].AddRange(bigGrid[i % 3 * 3 + j].GetRange(skip, 3));
			}
		}
		// check values
		for (int i = 0; i < 9; i++)
		{
			if (!IsProperValue(bigGrid[i]) || !IsProperValue(bigGrid.Select(x => x[i]).ToList()) || !IsProperValue(smallGrids[i]))
			{
				Console.WriteLine("false");
				return;
			}
		}
		Console.WriteLine("true");
		static bool IsProperValue(List<string> collection) => collection.Distinct().Count() == 9;

		#region version with 2 lists
		//List<string> numbers = new();
		//List<string> nines = new(9);
		//// rows
		//for (int i = 0; i < 9; i++)
		//{
		//	nines.Clear();
		//	nines.AddRange(Console.ReadLine().Split(' '));
		//	if (!CheckNumbers(nines))
		//	{
		//		return;
		//	}
		//	numbers.AddRange(nines);
		//}
		//// columns
		//for (int i = 0; i < 9; i++)
		//{
		//	nines.Clear();
		//	for (int j = i; j < 81; j += 9)
		//	{
		//		nines.Add(numbers.ElementAt(j));
		//	}
		//	if (!CheckNumbers(nines))
		//	{
		//		return;
		//	}
		//}
		//// squares
		//for (int i = 0; i < 81; i += 27)
		//{
		//	for (int j = i; j < i + 9; j += 3)
		//	{
		//		nines.Clear();
		//		for (int k = j; k < j + 3; k++)
		//		{
		//			nines.Add(numbers.ElementAt(k));
		//			nines.Add(numbers.ElementAt(k + 9));
		//			nines.Add(numbers.ElementAt(k + 18));
		//		}
		//		if (!CheckNumbers(nines))
		//		{
		//			return;
		//		}
		//	}
		//}
		//Console.WriteLine("true");
		//static bool CheckNumbers(List<string> collection)
		//{
		//	if (collection.Distinct().Count() != 9)
		//	{
		//		Console.WriteLine("false");
		//		return false;
		//	}
		//	return true;
		//}
		#endregion version with 2 lists

		#region first version with 2 dimensional array
		//string[,] numbers = new string[9, 9];
		//// rows
		//for (int i = 0; i < 9; i++)
		//{
		//	string[] inputs = Console.ReadLine().Split(' ');
		//	if (!IsProperValue(inputs))
		//	{
		//		Console.WriteLine("false");
		//		return;
		//	}
		//	for (int j = 0; j < 9; j++)
		//	{
		//		numbers[i, j] = inputs[j];
		//	}
		//}
		//// columns
		//string[] column = new string[9];
		//for (int i = 0; i < numbers.GetLength(0); i++)
		//{
		//	for (int j = 0; j < numbers.GetLength(1); j++)
		//	{
		//		column[j] = numbers[j, i];
		//	}
		//	if (!IsProperValue(column))
		//	{
		//		Console.WriteLine("false");
		//		return;
		//	}
		//}
		//// small squares
		//List<string> squares = new(9);
		//for (int i = 0; i < 9; i += 3)
		//{
		//	for (int j = 0; j < 9; j += 3)
		//	{
		//		squares.Clear();
		//		for (int k = i; k < i + 3; k++)
		//		{
		//			for (int m = j; m < j + 3; m++)
		//			{
		//				squares.Add(numbers[k, m]);
		//			}
		//		}
		//		if (!IsProperValue(squares))
		//		{
		//			Console.WriteLine("false");
		//			return;
		//		}
		//	}
		//}
		//Console.WriteLine("true");
		//private static bool IsProperValue(string[] collection) => collection.Distinct().Count() == 9;
		//private static bool IsProperValue(List<string> collection) => collection.Distinct().Count() == 9;
		#endregion first version with 2 dimensional array
	}

	public static void HORSE_RACING_DUALS()
	{
		int numberOfHorses = int.Parse(Console.ReadLine());
		List<int> horses = new(numberOfHorses);
		for (int i = 0; i < numberOfHorses; i++)
		{
			horses.Add(int.Parse(Console.ReadLine()));
		}
		horses.Sort();
		horses.Reverse();
		int min = horses[0];
		for (int i = 0; i < horses.Count - 1; i++)
		{
			if (horses[i] - horses[i + 1] < min)
			{
				min = horses[i] - horses[i + 1];
			}
		}
		Console.WriteLine(min);
	}

	public static void Power_of_Thor_Episode_1()
	{
		int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		int lightX = inputs[0]; // the X position of the light of power
		int lightY = inputs[1]; // the Y position of the light of power
		int initialTx = inputs[2]; // Thor's starting X position
		int initialTy = inputs[3]; // Thor's starting Y position

		while (true)
		{
			_ = int.Parse(Console.ReadLine()); // The remaining amount of turns
			string dir_X = "", dir_Y = "";

			if (initialTy < lightY)
			{
				initialTy++;
				dir_Y = "S";
			}
			else if (initialTy > lightY)
			{
				initialTy--;
				dir_Y = "N";
			}

			if (initialTx < lightX)
			{
				initialTx++;
				dir_X = "E";
			}
			else if (initialTx > lightX)
			{
				initialTx--;
				dir_X = "W";
			}

			Console.WriteLine(dir_Y + dir_X);
		}
	}

	public static void Defibrillators()
	{
		double userLongitude = double.Parse(Console.ReadLine().Replace(',', '.'));
		double userLatitude = double.Parse(Console.ReadLine().Replace(',', '.'));
		int numberOfDefibrillators = int.Parse(Console.ReadLine());
		double minValue = 0;
		string minName = string.Empty;
		for (int i = 0; i < numberOfDefibrillators; i++)
		{
			string[] defibrillator = Console.ReadLine().Split(';');
			string id = defibrillator[0];
			string name = defibrillator[1];
			string address = defibrillator[2];
			string phone = defibrillator[3];
			double defLongitude = double.Parse(defibrillator[4].Replace(',', '.'));
			double defLatitude = double.Parse(defibrillator[5].Replace(',', '.'));

			double x = (defLongitude - userLongitude) * Math.Cos((userLongitude + defLongitude) / 2);
			double y = defLatitude - userLatitude;
			double d = Math.Sqrt(x * x + y * y) * 6371;

			if (i == 0 || d < minValue)
			{
				minValue = d;
				minName = name;
			}
		}
		Console.WriteLine(minName);

		#region Another solution using using Defibrillator and AllDefibrillators class
		//class Solution
		//{
		//	static void Main(string[] args)
		//	{
		//		double userLon = double.Parse(Console.ReadLine().Replace(',', '.')); // degrees
		//		double userLat = double.Parse(Console.ReadLine().Replace(',', '.')); // degrees
		//		int n = int.Parse(Console.ReadLine()); // number of defibrillators
		//		AllDefibrillators allDefibrillators = new AllDefibrillators();
		//		for (int i = 0; i < n; i++)
		//		{
		//			allDefibrillators.Add(new Defibrillator(Console.ReadLine()));
		//		}
		//		string nearestDef = allDefibrillators.FindNearestDef(userLon, userLat);
		//		Console.WriteLine(nearestDef);
		//	}
		//}
		//class Defibrillator
		//{
		//	private string id;
		//	private string address;
		//	private string phone;
		//	public string Name { get; }
		//	public double DefLong { get; }
		//	public double DefLat { get; }
		//	public Defibrillator(string text)
		//	{
		//		string[] defibrillator = text.Split(';');
		//		id = defibrillator[0];
		//		Name = defibrillator[1];
		//		address = defibrillator[2];
		//		phone = defibrillator[3];
		//		DefLong = double.Parse(defibrillator[4].Replace(',', '.'));
		//		DefLat = double.Parse(defibrillator[5].Replace(',', '.'));
		//	}
		//}
		//class AllDefibrillators
		//{
		//	private List<Defibrillator> allDefibrillators;
		//	public AllDefibrillators() => allDefibrillators = new List<Defibrillator>();
		//	public void Add(Defibrillator defibrillator) => allDefibrillators.Add(defibrillator);
		//	public string FindNearestDef(double userLongtitude, double userLatitude)
		//	{
		//		double minValue = 0;
		//		string minName = string.Empty;
		//		for (int i = 0; i < allDefibrillators.Count; i++)
		//		{
		//			double x = (allDefibrillators[i].DefLong - userLongtitude) * Math.Cos((userLongtitude + allDefibrillators[i].DefLong) / 2);
		//			double y = allDefibrillators[i].DefLat - userLatitude;
		//			double d = Math.Sqrt(x * x + y * y) * 6371;
		//			if (i == 0 || d < minValue)
		//			{
		//				minValue = d;
		//				minName = allDefibrillators[i].Name;
		//			}
		//		}
		//		return minName;
		//	}
		//}
		#endregion Another solution using using Defibrillator and AllDefibrillators class
	}

	public static void Sum_of_Spirals_Diagonals()
	{
		int numberOfLayers = int.Parse(Console.ReadLine());
		long sum = 1;
		long number = 1;
		for (int i = numberOfLayers - 1; i > 0; i -= 2)
		{
			int iteration = (numberOfLayers % 2 == 0 && i == 1) ? 3 : 4;
			for (int j = 0; j < iteration; j++)
			{
				number += i;
				sum += number;
			}
		}
		Console.WriteLine(sum);

		#region first version
		//int n = int.Parse(Console.ReadLine());
		//long suma = 1;
		//long liczba = 1;
		//for (int i = n - 1; i > 0; i -= 2)
		//{
		//	for (int j = 0; j < 4; j++)
		//	{
		//		liczba += i;
		//		suma += liczba;
		//	}
		//}
		//if (n % 2 == 0)
		//{
		//	suma -= (n * n + 1);
		//}
		//Console.WriteLine(suma);
		#endregion first version
	}

	public static void Rock_Paper_Scissors_Lizard_Spock()
	{
		int n = int.Parse(Console.ReadLine());
		Game game = new();
		for (int i = 0; i < n; i++)
		{
			game.Add(new Player(Console.ReadLine()));
		}
		Player winner = game.PlayGame();
		Console.WriteLine($"{winner.Number}\n{winner.GetDefeatedEnemy()}");
	}

	private class Player
	{
		private readonly List<int> previousEnemies;
		public int Number { get; }
		public string Sign { get; }
		public Player(string text)
		{
			previousEnemies = new List<int>();
			string[] inputs = text.Split(' ');
			Number = int.Parse(inputs[0]);
			Sign = inputs[1];
		}
		public void AddDefeatedEnemy(int number) => previousEnemies.Add(number);
		public string GetDefeatedEnemy() => string.Join(" ", previousEnemies);
	}
	private class Game
	{
		private readonly Queue<Player> players;
		public Game() => players = new Queue<Player>();
		public void Add(Player player) => players.Enqueue(player);
		public Player PlayGame()
		{
			while (players.Count > 1)
			{
				Player winner = players.Dequeue();
				Player loser = players.Dequeue();
				Player player = CheckWinner(winner, loser);
				if (player.Equals(loser))
				{
					(winner, loser) = (loser, winner);
				}
				winner.AddDefeatedEnemy(loser.Number);
				players.Enqueue(winner);
			}
			return players.Dequeue();
		}
		private Player CheckWinner(Player player1, Player player2)
		{
			string sign1 = player1.Sign;
			string sign2 = player2.Sign;
			if ((sign1 == "C" && (sign2 == "P" || sign2 == "L"))
					|| (sign1 == "P" && (sign2 == "R" || sign2 == "S"))
					|| (sign1 == "R" && (sign2 == "L" || sign2 == "C"))
					|| (sign1 == "L" && (sign2 == "S" || sign2 == "P"))
					|| (sign1 == "S" && (sign2 == "C" || sign2 == "R")))
			{
				return player1;
			}
			else if ((sign2 == "C" && (sign1 == "P" || sign1 == "L"))
				|| (sign2 == "P" && (sign1 == "R" || sign1 == "S"))
				|| (sign2 == "R" && (sign1 == "L" || sign1 == "C"))
				|| (sign2 == "L" && (sign1 == "S" || sign1 == "P"))
				|| (sign2 == "S" && (sign1 == "C" || sign1 == "R")))
			{
				return player2;
			}
			else
			{
				return player1.Number < player2.Number ? player1 : player2;
			}
		}
	}
}