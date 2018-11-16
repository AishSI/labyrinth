using System;

namespace Mazes
{
    public static class EmptyMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            int longSide = Math.Max(width, height);
            for (int x = 0; x < longSide - 3; x++)
            {
                NoVerticallWall(robot, width);
                NoHorisontalWall(robot, height);
            }
        }

        public static void NoVerticallWall(Robot robot, int width)
        {
            if (robot.X < width - 2) robot.MoveTo(Direction.Right);
        }

        public static void NoHorisontalWall(Robot robot, int height)
        {
            if (robot.Y < height - 2) robot.MoveTo(Direction.Down);
        }
    }
}