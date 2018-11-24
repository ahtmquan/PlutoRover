using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoRoverController
{
    public class PlutoRover
    {
        private IMover CurrentMover;

        public Position Position { get; set; }
        public Direction Direction { get; set; }

        public Dictionary<Direction, IMover> Movers = new Dictionary<Direction, IMover>();

        public PlutoRover()
        {
            this.Position = new Position() { X = 0, Y = 0 };
            this.Direction = Direction.N;

            Movers.Add(Direction.N, new NMover(this.Position));
            Movers.Add(Direction.S, new SMover(this.Position));
            Movers.Add(Direction.E, new EMover(this.Position));
            Movers.Add(Direction.W, new WMover(this.Position));

            SetMover();
        }

        void SetMover()
        {
            CurrentMover = Movers[this.Direction];
        }

        void TurnLeft()
        {
            this.Direction = CurrentMover.TurnLeft();

            SetMover();
        }

        void TurnRight()
        {
            this.Direction = CurrentMover.TurnRight();

            SetMover();
        }

        void MoveForward()
        {
            this.CurrentMover.MoveFoward();
        }

        void MoveBack()
        {
            this.CurrentMover.MoveBack();
        }


        /// <summary>
        /// NASA sends a simple string of letters
        /// </summary>
        /// <param name="command"></param>
        public void ReceiveCommand(string command)
        {
            char[] codes = command.Trim().ToCharArray();

            foreach (char code in codes)
            {
                switch (code)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'F':
                        MoveForward();
                        break;
                    case 'B':
                        MoveBack();
                        break;
                }
            }
        }


    }
}
