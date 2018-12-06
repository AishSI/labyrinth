
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
			int minField = (fieldWidth > fieldHeight) ? fieldHeight : fieldWidth;
			SettingsStep(fieldWidth, fieldHeight, minField);
			while ((robot.X < fieldWidth) || (robot.Y < fieldHeight))
			{
				vectorSwitch *= -1;
				MoveToExit(robot, vectorSwitch, rightSteps, downSteps);
			}
		}

		public static void SettingsStep(int width, int height, int min)
		{
			vectorSwitch = (width > height) ? -1 : 1;
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