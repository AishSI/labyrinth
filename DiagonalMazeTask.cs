using System;

namespace Mazes
{
	public class DiagonalMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			int fieldWidth = width - 2;
			int fieldHeight = height - 2;
			Direction direction = width > height ? Direction.Right : Direction.Down;
			(int rightSteps, int downSteps) = SettingsStep(fieldWidth, fieldHeight);
			while (!robot.Finished)
			{
				MoveToExit(robot, direction, rightSteps, downSteps);
				direction = changeDirection(direction);
			}
		}

		public static void MoveToExit(Robot robot, Direction direction, int rightSteps, int downSteps)
		{
			if (direction == Direction.Right)
				for (int x = 0; x < rightSteps; x++)
					robot.MoveTo(Direction.Right);
			if (direction == Direction.Down)
				for (int y = 0; y < downSteps; y++)
					robot.MoveTo(Direction.Down);
		}

		public static (int, int) SettingsStep(int fieldWidth, int fieldHeight)
		{
			int fieldMmin = Math.Min(fieldWidth, fieldHeight);
			int rightSteps = fieldWidth / fieldMmin;
			int downSteps = fieldHeight / fieldMmin;
			return (rightSteps, downSteps);
		}

		private static Direction changeDirection(Direction direction)
		{
			if (direction.Equals(Direction.Right))
				return Direction.Down;
			return Direction.Right;
		}
	}
}