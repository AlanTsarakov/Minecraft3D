using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft3D
{
    public class Block
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Block(int x, int y) 
        {
            X = x;
            Y = y;
            Z = 0;
        }
        public Block(int x, int y, int z) : this(x, y)
        {
            Z = z;
        }
    }
}
