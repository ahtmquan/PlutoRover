using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoRoverController
{
    public class Mover : IMover
    {
        protected Position Position;

        public Mover(Position position)
        {
            this.Position = position;
        }

        public virtual void MoveFoward()
        {

        }

        public virtual void MoveBack()
        {

        }

        public virtual Direction TurnLeft() {
            throw new Exception();
        }

        public virtual Direction TurnRight(){
            throw new Exception();
        }
    }
}
