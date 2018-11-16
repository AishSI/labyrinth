using System;

namespace Mazes
{
    public static class EmptyMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            MoveToWall(robot, width, Direction.Right);
            MoveToWall(robot, height, Direction.Down);
        }

        public static void MoveToWall(Robot robot, int count, Direction direction)
        {
            for (int i = 0; i < count - 3; i++)
                robot.MoveTo(direction);
        } 
    }
}