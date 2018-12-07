namespace Mazes
{
	public static class DiagonalMazeTask
	{
		static int vectorSwitch;
		static int rightSteps;
		static int downSteps;

		public static void MoveOut(Robot robot, int width, int height)
		{
			int fieldWidth = width - 2;
			int fieldHeight = height - 2;
			int fieldMmin = (fieldWidth > fieldHeight)
				? fieldHeight
				: fieldWidth;

			SettingsStep(fieldWidth, fieldHeight, fieldMmin);

			while (!robot.Finished)
			{
				MoveToExit(robot, vectorSwitch, rightSteps, downSteps);
				vectorSwitch *= -1;
			}
		}

		public static void SettingsStep(int width, int height, int min)
		{
			vectorSwitch = (width > height) // vectorSwitch = 1 горизонтальный ход, -1 вертикальный
				? 1
				: -1;
			rightSteps = width / min;
			downSteps = height / min;
		}

		public static void MoveToExit(Robot robot, int vectorSwith, int rightSteps, int downSteps)
		{
			if (vectorSwith > 0) // vector = 1 горизонтальный ход, -1 вертикальный
				for (int x = 0; x < rightSteps; x++)
					robot.MoveTo(Direction.Right);
			else
				for (int y = 0; y < downSteps; y++)
					robot.MoveTo(Direction.Down);
		}
	}
}