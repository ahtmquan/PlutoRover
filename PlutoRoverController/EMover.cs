using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoRoverController
{
    public class EMover : Mover
    {
        public EMover(Position position) : base(position) { }

        public override void MoveFoward()
        {
            this.Position.Y++;
        }

        public override void MoveBack()
        {
            this.Position.Y--;
        }
    }
}
