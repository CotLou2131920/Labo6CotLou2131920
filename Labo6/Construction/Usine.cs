using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    class Usine
    {
        public Robot[] robot;
        //public Robot CreeRobotEvaluateur()
        //{

        //    return evaluateur;
        //}
        public Usine()
        {
            Piece[] p = new Piece[3];
            this.robot = new Robot[3];
            p[0] = new Destruction(1);
            p[1] = new Transport(1);
            p[2] = new Construction(1);
            for (int i = 0; i < 3; i++)
                robot[i] = CreeRobot(p[i], robot[i]);
            
        }

        public Robot CreeRobot(Piece piece, Robot rob)
        {
            if (piece is Vitesse)
                rob = new Robot(piece, piece, piece);
            else if (piece is Construction)
                rob = new Robot(piece, piece, piece);
            else if (piece is Destruction)
                rob = new Robot(piece, piece, piece);
            else
                rob = new Robot(piece, piece, piece);
            return rob;
        }
    }
}
