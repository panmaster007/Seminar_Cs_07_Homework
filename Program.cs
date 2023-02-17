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

// здесь располагаем методы для выполнения задач

void Task_47()
{
	// Здесь вызываем необходимые методы для выполнения 1-й задачи
}

void Task_50()
{
	// Здесь вызываем необходимые методы для выполнения 2-й задачи
}

void Task_52()
{
	// Здесь вызываем необходимые методы для выполнения 2-й задачи
}

TaskMenu();