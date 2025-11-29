using codurance_kata_interview.Services;

namespace codurance_kata_interview
{
    public class Robot
    {
        public Coordinates coordinates { get; set; }
        public Direction Direction;        

        public IMoveService moveService;
        public IRotateService rotateService;

        public Robot(IMoveService _moveService, IRotateService _rotateService) 
        { 
            coordinates = new(0,0);
            Direction = Direction.N;
            moveService = _moveService;
            rotateService = _rotateService;
        }

        public string Execute(string command)
        {
            var commands = command.ToArray();

            foreach (var order in commands)
            {
                Direction = rotateService.Rotate(order, Direction);

                if(order == 'M')
                {
                    coordinates = moveService.Move(coordinates, Direction);
                }                
            }            
            return $"{coordinates.X}:{coordinates.Y}:{Direction}";
        }
    }
}
