namespace PlutoRoverController
{
    public interface IMover
    {
        void MoveBack();
        void MoveFoward();
        Direction TurnLeft();
        Direction TurnRight();
    }
}