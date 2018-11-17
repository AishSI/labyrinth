namespace Mazes
{
    public static class DiagonalMazeTask
    {
        //static int flag = 1; //Значение по умолчанию. Предполагает, что ширина больше высоты и задает первый шаг по горизонтали.
        //static int aspectRatio = 1; // По умолчанию устанавливается соотношение шага по вертикали и горизонтали как 1:1.

        public static void MoveOut(Robot robot, int width, int height)
        {
            if (width > height)
                while (robot.Y < height - 2)
                    MoveToHorizontalDiagonal(robot, width, height);
            else
                while (robot.Y < height - 2)
                    MoveToVerticalDiagonal(robot, width, height);
            if (robot.X < width - 2)
                MoveToHorizontalDiagonal(robot, width, height);
            if (robot.Y < height - 2)
                MoveToVerticalDiagonal(robot, width, height);
        }

        public static void MoveToHorizontalDiagonal(Robot robot, int width, int height)
        {
            int aspectRatio = (width-2) / (height-2); 
                for (int x = 0; x < aspectRatio; x++)
                    robot.MoveTo(Direction.Right);
                if (robot.Y < height - 2)
                    robot.MoveTo(Direction.Down);
        }

        public static void MoveToVerticalDiagonal(Robot robot, int width, int height)
        {
            int aspectRatio = (height-2) / (width-2);
                for (int y = 0; y < aspectRatio; y++)
                    robot.MoveTo(Direction.Down);
                if (robot.X < width - 2)
                    robot.MoveTo(Direction.Right);
        }
    }
}