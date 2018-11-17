using System.Linq;

namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            int[] pole = { width - 2, height - 2 }; // Размер внутреннего поля
            int smallerSideStep = System.Math.Min(pole[0], pole[1]); // Размер меньшей стороны
            int[] numberOfSteps = { pole[0] / smallerSideStep, pole[1] / smallerSideStep }; // Количество клеток по горизонтали и вертикали в одном ходе
            int countOfCompleteSteps = System.Math.Min(pole[0] - 1 / numberOfSteps[0], pole[1] - 1 / numberOfSteps[1]); // Количество полных ходов
            for (int i = 0; i < countOfCompleteSteps; i++)
                MoveToDiagonal(robot, numberOfSteps);
            MoveToLastSteps(robot, pole, numberOfSteps);
        }

        public static void MoveToDiagonal(Robot robot, int[] numberOfSteps)
        {
            for (int i = 0; i < numberOfSteps.Max(); i++)
                robot.MoveTo(numberOfSteps[0] > numberOfSteps[1] ? Direction.Right: Direction.Down);
            for (int i = 0; i < numberOfSteps.Min(); i++)
                robot.MoveTo(numberOfSteps[0] > numberOfSteps[1] ? Direction.Down : Direction.Right);
        }

        //Если полных ходов не хватило для выхода, определяемся и делаем вертикальный или горизонтальный "полуход";
        public static void MoveToLastSteps(Robot robot, int[] pole, int[] numberOfSteps)
        {
            if (robot.X < pole[0])
                for (int i = 0; i < numberOfSteps[0]; i++)
                    robot.MoveTo(Direction.Right);
            if (robot.Y < pole[1])
                for (int i = 0; i < numberOfSteps[1]; i++)
                    robot.MoveTo(Direction.Down);
        }
    }
}