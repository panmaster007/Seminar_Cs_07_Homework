void TaskMenu()
{
	bool exitOut = true;

	while (exitOut == true)
	{
		Console.WriteLine("Введите номер задачи(47, 50, 52, либо q/Q для выхода):");
		string selectTask = "";
		selectTask = Console.ReadLine();

		switch (selectTask)
		{
			case "47":
				{
					Console.Clear();
					Task_47();
					break;
				}

			case "50":
				{
					Console.Clear();
					Task_50();
					break;
				}

			case "52":
				{
					Console.Clear();
					Task_52();
					break;
				}

			case "q":
				{
					exitOut = false;
					Console.Clear();
					break;
				}

			case "Q":
				{
					exitOut = false;
					Console.Clear();
					break;
				}

			default:
				{
					Console.WriteLine("Вы не попали в нужную кнопку, попробуйте ещё раз!");
					break;
				}
		}
	}
}

// здесь располагаем методы для выполнения наших задач
double[,] CreateTwoDimensionArrayDouble(int firstLength, int secondLength)
{
	double[,] result = new double[firstLength, secondLength];
	Random rnd = new Random();

	for (int i = 0; i < result.GetLength(0); i++)
	{
		for (int j = 0; j < result.GetLength(1); j++)
		{
			result[i, j] = Math.Round((rnd.NextDouble() * 20) - 10, 1);
		}
	}
	return result;
}

string TwoDimensionArrayToStringDouble(double[,] array)
{
	string result = string.Empty; // "";

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			result += $"{array[i, j]} ";
		}

		result += Environment.NewLine; // "\n"
	}

	return result;
}

int[,] CreateTwoDimensionArrayInteger(int firstLength, int secondLength)
{
	int[,] result = new int[firstLength, secondLength];
	Random rnd = new Random();

	for (int i = 0; i < result.GetLength(0); i++)
	{
		for (int j = 0; j < result.GetLength(1); j++)
		{
			result[i, j] = rnd.Next(0, 10);
		}
	}
	return result;
}

string TwoDimensionArrayToStringInteger(int[,] array)
{
	string result = string.Empty; // "";

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			result += $"{array[i, j]} ";
		}

		result += Environment.NewLine; // "\n"
	}

	return result;
}

int ReadInteger(string argument)
{
	Console.Write($"Input {argument}: ");
	int result = 0;

	while (!int.TryParse(Console.ReadLine(), out result))
	{
		Console.WriteLine("Try again");
	}

	return result;
}

void ItemPositionAnalysis(int[,] array, int i, int j)
{
	int result = 0;
	if ((i - 1) < array.GetLength(0) && (j - 1) < array.GetLength(1))
	{
		Console.WriteLine(array[i - 1, j - 1]);
	}
	else
	{
		Console.WriteLine("Числа на данной позиции не существует!!!");
	}
}

void Task_47()
{
	// Здесь вызываем необходимые методы для выполнения 47-й задачи
	double[,] array = CreateTwoDimensionArrayDouble(3, 4);
	Console.WriteLine(TwoDimensionArrayToStringDouble(array));
}

void Task_50()
{
	// Здесь вызываем необходимые методы для выполнения 50-й задачи
	int[,] array = CreateTwoDimensionArrayInteger(3, 4);
	Console.WriteLine(TwoDimensionArrayToStringInteger(array));
	int i = ReadInteger("Введите номер строки: ");
	int j = ReadInteger("Введите номер столбца: ");
	ItemPositionAnalysis(array, i, j);
}

void Task_52()
{
	// Здесь вызываем необходимые методы для выполнения 52-й задачи
}

TaskMenu();