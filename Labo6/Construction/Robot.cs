using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    class Robot
    {
        Piece[] piece;
        public bool disponible { get; set; }

        public Robot(Piece p1, Piece p2, Piece p3) 
        {
            piece = new Piece[3];
            piece[0] = p1;
            piece[1] = p2;
            piece[2] = p3;
            disponible = true;
        }
    }
}
