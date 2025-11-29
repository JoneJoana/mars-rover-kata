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
                coordinates.y++;
                if (coordinates.y == plateau.y)
                {
                    coordinates.y = 0;
                }
            }
            if (direction == Direction.W)
            {
                if (coordinates.x == 0)
                {
                    coordinates.x = plateau.x;
                }
                coordinates.x--;
            }
            if (direction == Direction.E)
            {
                coordinates.x++;
                if (coordinates.x == plateau.x)
                {
                    coordinates.x = 0;
                }
            }
            if (direction == Direction.S)
            {
                if (coordinates.y == 0)
                {
                    coordinates.y = plateau.y;
                }
                coordinates.y--;
            }

            return coordinates;
        }
    }
}
