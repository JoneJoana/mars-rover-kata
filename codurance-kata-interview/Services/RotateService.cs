namespace codurance_kata_interview.Services
{
    public class RotateService: IRotateService
    {
        public Direction Rotate(char command, Direction direction)
        {
            if (command == 'R')
            {
                return RotateRight(direction);
            }
            if (command == 'L')
            {
                return RotateLeft(direction);
            }

            return direction;
        }
        private Direction RotateRight(Direction direction)
        {
            if (direction == Direction.N)
            {
                return Direction.E;
            }
            else if (direction == Direction.E)
            {
                return Direction.S;
            }
            else if (direction == Direction.S)
            {
                return Direction.W;
            }
            
            return Direction.N;
        }

        private Direction RotateLeft(Direction direction)
        {
            if (direction == Direction.N)
            {
                return Direction.W;
            }
            else if (direction == Direction.W)
            {
                return Direction.S;
            }
            else if (direction == Direction.S)
            {
                return Direction.E;
            }

            return Direction.N;
        }

    }
}
