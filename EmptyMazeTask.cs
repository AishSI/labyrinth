using System;

namespace Mazes
{
    public class EmptyMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
			var emtyMazeTask = new EmptyMazeTask();
            emtyMazeTask.MoveToWall(robot, width, Direction.Right);
			emtyMazeTask.MoveToWall(robot, height, Direction.Down);
        }

        public void MoveToWall(Robot robot, int count, Direction direction)
        {
            for (int i = 0; i < count - 3; i++)
                robot.MoveTo(direction);
        }
    }
}