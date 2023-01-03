namespace CodinGame
{
	internal static class Easy
	{
		public static bool MIME_Type()
		{
			int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
			int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
			Dictionary<string, string> fileExtensions = new();
			for (int i = 0; i < N; i++)
			{
				string[] inputs = Console.ReadLine().Split(' ');
				fileExtensions[$".{inputs[0].ToLower()}"] = inputs[1];
			}
			List<string> files = new();
			for (int i = 0; i < Q; i++)
			{
				files.Add(fileExtensions.GetValueOrDefault(Path.GetExtension(Console.ReadLine().ToLower())) ?? "UNKNOWN");
			}
			foreach (var item in files)
			{
				Console.WriteLine(item);
			}
			return true;

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
			#endregion

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
			#endregion

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
			#endregion

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
			#endregion
		}

		public static bool Temperatures()
		{
			if (int.Parse(Console.ReadLine()) != 0) // the number of temperatures to analyse
			{
				int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				int min = inputs.Min(Math.Abs);
				Console.WriteLine(inputs.Contains(min) ? min : -min);
			}
			else
			{
				Console.WriteLine(0);
			}
			return true;

			#region first version
			//int numberOfTemperatures = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
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
			#endregion

			#region second version
			//int closestToZero = 0;
			//if (int.Parse(Console.ReadLine()) != 0) // the number of temperatures to analyse
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
			#endregion

			#region using Aggregate
			//int n = int.Parse(Console.ReadLine());
			//var temps = Console.ReadLine().Split(' ').Take(n).Select(int.Parse);
			//Console.WriteLine(n == 0 ? 0 : temps.Aggregate(int.MaxValue, (min, temp) => Math.Abs(temp) < Math.Abs(min) || temp == -min && temp > 0 ? temp : min));
			#endregion
		}

		public static bool The_Descent()
		{
			int[] collection = new int[8];
			while (true)
			{
				for (int i = 0; i < 8; i++)
					collection[i] = int.Parse(Console.ReadLine());
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
			#endregion
		}

		public static bool Mars_Lander_Episode_1()
		{
			int[] inputs;
			int surfaceN = int.Parse(Console.ReadLine()); // the number of points used to draw the surface of Mars.
			for (int i = 0; i < surfaceN; i++)
			{
				inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				int landX = inputs[0]; // X coordinate of a surface point. (0 to 6999)
				int landY = inputs[1]; // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
			}

			// game loop
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

				if (vSpeed < -40)
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
			return true;
		}

		public static bool ASCII_Art()
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
			return true;
		}

		public static bool Unary()
		{

			return true;
		}
	}
}