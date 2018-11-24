using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoRoverController
{
    public class NMover: Mover
    {
        public NMover(Position position) : base(position) { }

        public override void MoveFoward()
        {
            this.Position.X++;
        }

        public override void MoveBack()
        {
            this.Position.X--;
        }

        public override Direction TurnLeft()
        {
            return Direction.W;
        }

        public override Direction TurnRight()
        {
            return Direction.E;
        }
    }
}
