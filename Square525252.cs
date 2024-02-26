using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Уч__пр_3
{
    class Square:Figure
    {
        private int side1;

        public Square(string name, int side1) : base(name)
        {
            this.side1 = side1;
        }
        public override double Area()
        {
            return Math.Pow(side1, 2);
        }
    }
}
