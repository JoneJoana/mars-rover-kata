namespace codurance_kata_interview
{
    public class Robot
    {
        public int x;
        public int y;
        public Directions Direction; 

        public Robot() 
        { 
            x = 0;
            y = 0;
            Direction = Directions.N;
        }

        public string Execute(string command)
        {
            var commands = command.ToArray();

            foreach (var order in commands)
            {
                rotateLeft(order);
                rotateRight(order);
                move(order);
            }            
            return $"{x}:{y}:{Direction}";
        }

        private void move(char command)
        {
            if (command == 'M')
            {
                if (Direction == Directions.N)
                {
                    y++;
                }
                if (Direction == Directions.W)
                {
                    x--;
                }
                if (Direction == Directions.E)
                {
                    x++;
                }
                if (Direction == Directions.S)
                {
                    y--;
                }
            }
        }

        private void rotateRight(char command)
        {
            if (command == 'R')
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
        }

        private void rotateLeft(char command)
        {
            if (command == 'L')
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

    public enum Directions
    {
        N = 0,
        E = 1,
        S = 2,
        W = 3
    }


}
