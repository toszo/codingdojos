namespace Coding.Dojo.LangtonsAnt
{
    public class Ant
    {
        private Direction _direction;

        public Direction Direction => _direction;
        public Field CurrentPosition { get; } 

        public Ant(Direction direction = Direction.North)
        {
            CurrentPosition = new Field(0,0);
            _direction = direction;
        }

        public void Move(Color fieldColor)
        {
            if (fieldColor == Color.White)
            {
                TurnLeft();
                CurrentPosition.Color = Color.Black;
            }

            else
            {
                TurnRight();
            }
                
        }

        private void TurnRight()
        {
            _direction = (Direction) ((int) (_direction + 1) % 4);
        }

        private void TurnLeft()
        {
            var direction = (int) (_direction - 1);
            _direction = (Direction) (direction < 0 ? 3 : direction);
        }
    }
}