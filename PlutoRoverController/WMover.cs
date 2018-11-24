using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoRoverController
{
    public class WMover : Mover
    {
        public WMover(Position position) : base(position) { }

        public override void MoveFoward()
        {
            this.Position.Y--;
        }

        public override void MoveBack()
        {
            this.Position.Y++;
        }

        public override Direction TurnLeft()
        {
            return Direction.S;
        }

        public override Direction TurnRight()
        {
            return Direction.N;
        }
    }
}
