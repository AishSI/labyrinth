using System;

namespace Mazes
{
    public static class EmptyMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            MoveToVerticalWalll(robot, width, Direction.Right);
            MoveToHorizontalWall(robot, height, Direction.Down);
        }

        public static void MoveToVerticalWalll(Robot robot, int count, Direction direction)
        {
            while (robot.X < count - 2)
                robot.MoveTo(direction);
        }

        public static void MoveToHorizontalWall(Robot robot, int count, Direction direction)
        {
            while (robot.Y < count - 2)
                robot.MoveTo(direction);
        }
    }
}