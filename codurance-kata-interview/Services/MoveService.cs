namespace codurance_kata_interview.Services
{
    public class MoveService : IMoveService
    {
        public Plateau plateau;
        public MoveService(Plateau _plateau)
        {
            plateau = _plateau;
        }

        public Coordinates Move(Coordinates coordinates, Direction direction)
        {            
            if (direction == Direction.N)
            {
                MoveNorth(coordinates);
            }
            if (direction == Direction.W)
            {
                MoveWest(coordinates);
            }
            if (direction == Direction.E)
            {
                MoveEast(coordinates);
            }
            if (direction == Direction.S)
            {
                MoveSouth(coordinates);
            }

            return coordinates;
        }

        private void MoveSouth(Coordinates coordinates)
        {
            if (coordinates.Y == 0)
            {
                coordinates.Y = plateau.Y;
            }
            coordinates.Y--;
        }

        private void MoveEast(Coordinates coordinates)
        {
            coordinates.X++;
            if (coordinates.X == plateau.X)
            {
                coordinates.X = 0;
            }
        }

        private void MoveWest(Coordinates coordinates)
        {
            if (coordinates.X == 0)
            {
                coordinates.X = plateau.X;
            }
            coordinates.X--;
        }

        private void MoveNorth(Coordinates coordinates)
        {
            coordinates.Y++;
            if (coordinates.Y == plateau.Y)
            {
                coordinates.Y = 0;
            }
        }
    }
}
