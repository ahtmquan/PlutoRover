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

        private IMover NMover;
        private IMover SMover;
        private IMover WMover;
        private IMover EMover;

        public Position Position { get; set; }
        public Direction Direction { get; set; }

        public PlutoRover()
        {
            this.Position = new Position() { X = 0, Y = 0 };
            this.Direction = Direction.N;

            NMover = new NMover(this.Position);
            SMover = new SMover(this.Position);
            EMover = new EMover(this.Position);
            WMover = new WMover(this.Position);

            SetMover();
        }

        void SetMover()
        {
            switch (this.Direction)
            {
                case Direction.N:
                    CurrentMover = NMover;
                    break;
                case Direction.S:
                    CurrentMover = SMover;
                    break;
                case Direction.W:
                    CurrentMover = WMover;
                    break;
                case Direction.E:
                    CurrentMover = EMover;
                    break;
            }
        }

        void TurnLeft()
        {
            switch (this.Direction)
            {
                case Direction.N:
                    this.Direction = Direction.W;
                    break;
                case Direction.S:
                    this.Direction = Direction.E;
                    break;
                case Direction.W:
                    this.Direction = Direction.S;
                    break;
                case Direction.E:
                    this.Direction = Direction.N;
                    break;
            }

            SetMover();
        }

        void TurnRight()
        {
            switch (this.Direction)
            {
                case Direction.N:
                    this.Direction = Direction.E;
                    break;
                case Direction.S:
                    this.Direction = Direction.W;
                    break;
                case Direction.W:
                    this.Direction = Direction.N;
                    break;
                case Direction.E:
                    this.Direction = Direction.S;
                    break;
            }

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
