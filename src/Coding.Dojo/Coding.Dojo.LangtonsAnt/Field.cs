namespace Coding.Dojo.LangtonsAnt
{
    public class Field
    {
        private readonly int _x;
        private readonly int _y;

        public Color Color { get; set; }

        public Field(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override bool Equals(object obj)
        {
            return Equals((Field) obj);
        }

        protected bool Equals(Field other)
        {
            return _x == other._x && _y == other._y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_x * 397) ^ _y;
            }
        }
    }
}