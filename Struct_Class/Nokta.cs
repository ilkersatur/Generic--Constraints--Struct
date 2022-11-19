using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Class
{
    internal struct Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Yaz()
        {
            Console.WriteLine($"N({X},{Y})");
        }
        public Nokta(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}