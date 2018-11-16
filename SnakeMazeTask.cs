using System;

namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
        {
            SnakeToRight(robot, width);
            SnakeToLeft(robot, width);
        }

        public static void MoveTolWall(Robot robot, int count, Direction direction)
        {
            for (int i = 0; i < count - 3; i++ )            
                robot.MoveTo(direction);
        }

        public static void SnakeToRight(Robot robot, int width)
        {
            MoveTolWall(robot, width, Direction.Right);
            MoveTolWall(robot, 5, Direction.Down);
        }

        public static void SnakeToLeft(Robot robot, int width)
        {
            MoveTolWall(robot, width, Direction.Left);
            MoveTolWall(robot, 5, Direction.Down);
        }

        //public static void MoveToHorizontalWall(Robot robot, int count, Direction direction)
        //{
        //    while (robot.Y < count - 2)
        //        robot.MoveTo(direction);
        //}
    }
}