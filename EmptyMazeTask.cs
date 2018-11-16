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
                if (robot.X < width - 2) robot.MoveTo(Direction.Right);
                if (robot.Y < height - 2) robot.MoveTo(Direction.Down);
            }
        }
    }  
}