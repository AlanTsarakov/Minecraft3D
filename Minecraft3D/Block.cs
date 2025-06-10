using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Minecraft3D
{
    public class Block
    {
        public string Name { get; set; }
        public int X {  get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Block(string name,int x, int y) 
        {
            Name = name;
            X = x;
            Y = y;
            Z = 0;
        }
        public Block(string name, int x, int y, int z) : this(name, x, y)
        {
            Z = z;
        }
    }
}
