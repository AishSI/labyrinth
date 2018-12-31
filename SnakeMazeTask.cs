namespace Mazes
{
	public class SnakeMazeTask
	{
		int vectorSwitch = 1; // 1 = право ходи, -1 = лево ходи
		int downSteps = 2;

		public static void MoveOut(Robot robot, int width, int height)
		{
			int fieldWidth = width - 2;
			int fieldHeight = height - 2;
			int horizontalSteps = fieldWidth - 1;
			var snakeMazeTask = new SnakeMazeTask();
			while (!robot.Finished)
			{
				snakeMazeTask.MoveToExit(robot, snakeMazeTask.vectorSwitch, horizontalSteps, snakeMazeTask.downSteps);
				snakeMazeTask.vectorSwitch *= -1;
			}
		}

		public void MoveToExit(Robot robot, int vectorHorizontal, int horisontal, int vertical)
		{
			var direction = vectorHorizontal > 0
				? Direction.Right
				: Direction.Left;
			for (int x = 0; x < horisontal; x++)
				robot.MoveTo(direction);
			MoveToNextHorizont(robot, vertical);
		}

		public void MoveToNextHorizont(Robot robot, int vertical)
		{
			if (!robot.Finished)
				for (int y = 0; y < vertical; y++)
					robot.MoveTo(Direction.Down);
		}
	}
}