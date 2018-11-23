using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoRoverController
{
    public class SMover : Mover
    {
        public SMover(Position position) : base(position) { }

        public override void MoveFoward()
        {
            this.Position.X--;
        }

        public override void MoveBack()
        {
            this.Position.X++;
        }
    }
}
