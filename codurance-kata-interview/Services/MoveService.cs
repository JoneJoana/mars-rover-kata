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
            if (coordinates.y == 0)
            {
                coordinates.y = plateau.y;
            }
            coordinates.y--;
        }

        private void MoveEast(Coordinates coordinates)
        {
            coordinates.x++;
            if (coordinates.x == plateau.x)
            {
                coordinates.x = 0;
            }
        }

        private void MoveWest(Coordinates coordinates)
        {
            if (coordinates.x == 0)
            {
                coordinates.x = plateau.x;
            }
            coordinates.x--;
        }

        private void MoveNorth(Coordinates coordinates)
        {
            coordinates.y++;
            if (coordinates.y == plateau.y)
            {
                coordinates.y = 0;
            }
        }
    }
}
