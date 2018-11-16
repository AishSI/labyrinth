using System;

namespace Mazes
{
    public static class EmptyMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
                GoInVerticallWall(robot, width);
                GoinHorisontalWall(robot, height);
        }

        public static void GoInVerticallWall(Robot robot, int width)
        {
            while (robot.X < width - 2) robot.MoveTo(Direction.Right);
        }

        public static void GoinHorisontalWall(Robot robot, int height)
        {
            while (robot.Y < height - 2) robot.MoveTo(Direction.Down);
        }
    }
}