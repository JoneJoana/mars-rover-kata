namespace codurance_kata_interview
{
    public class Robot
    {
        public int x;
        public int y;
        public Directions Direction;
        public Plateau plateau;

        public Robot(Plateau _plateau) 
        { 
            x = 0;
            y = 0;
            Direction = Directions.N;
            plateau = _plateau;
        }

        public string Execute(string command)
        {
            var commands = command.ToArray();

            foreach (var order in commands)
            {
                Rotate(order);
                Move(order);
            }            
            return $"{x}:{y}:{Direction}";
        }

        private void Move(char command)
        {
            if (command != 'M')
                return;

            if (Direction == Directions.N)
            {
                y++;
                if (y == plateau.y)
                {
                    y = 0;
                }
            }
            if (Direction == Directions.W)
            {
                if (x == 0)
                {
                    x = plateau.x;
                }
                x--;
            }
            if (Direction == Directions.E)
            {
                x++;
                if (x == plateau.x)
                {
                    x = 0;
                }
            }
            if (Direction == Directions.S)
            {
                if (y == 0)
                {
                    y = plateau.y;
                }
                y--;
            }
        }

        private void Rotate(char command)
        {
            if (command == 'R')
            {
                RotateRight();
            }
            if (command == 'L')
            {
                RotateLeft();
            }
        }

        private void RotateRight()
        {
            if (Direction == Directions.N)
            {
                Direction = Directions.E;
            }
            else if (Direction == Directions.E)
            {
                Direction = Directions.S;
            }
            else if (Direction == Directions.S)
            {
                Direction = Directions.W;
            }
            else if (Direction == Directions.W)
            {
                Direction = Directions.N;
            }
        }

        private void RotateLeft()
        {
            if (Direction == Directions.N)
            {
                Direction = Directions.W;
            }
            else if (Direction == Directions.W)
            {
                Direction = Directions.S;
            }
            else if (Direction == Directions.S)
            {
                Direction = Directions.E;
            }
            else if (Direction == Directions.E)
            {
                Direction = Directions.N;
            }
        }
    }

}
