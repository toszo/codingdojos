using System.Collections.Generic;

namespace Coding.Dojo.LangtonsAnt
{
    public class World

    {
        public List<Field> Fields;

        public World()
        {
            Fields = new List<Field> { new Field(0, 0) };
        }
    }
}