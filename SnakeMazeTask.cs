using System;

namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
        {
            while (robot.Y < height - 2)
            {
                OneSegmentSnake(robot, width);
                if (robot.Y < height - 2)
                    MoveToNextSegment(robot, width);
            }
        }

        public static void MoveTolWall(Robot robot, int count, Direction direction)
        {
            for (int i = 0; i < count - 3; i++ )            
                robot.MoveTo(direction);
        }

        public static void OneSegmentSnake(Robot robot, int width)
        {
            MoveTolWall(robot, width, Direction.Right);
            MoveTolWall(robot, 5, Direction.Down);
            MoveTolWall(robot, width, Direction.Left);
        }

        public static void MoveToNextSegment(Robot robot, int width)
        {            
            MoveTolWall(robot, 5, Direction.Down);
        } 
    }
}