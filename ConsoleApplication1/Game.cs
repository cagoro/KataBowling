namespace KataBowling
{
    public class Game
    {
        private int _pinCount;
        private bool wasThereASpare;
        private int _previousPins;
        private bool _isAFirstShot;

        public Game()
        {
            _isAFirstShot = true;
        }

        public void Roll(int pins)
        {
            if (_isAFirstShot)
            {
                if (wasThereASpare)
                {
                    _pinCount += pins * 2;
                    wasThereASpare = false;
                }
                else
                {
                    _pinCount += pins;
                }
                _isAFirstShot = false;
            }
            else
            {
                _pinCount += pins;
                wasThereASpare = _previousPins + pins == 10;
                _isAFirstShot = true;
            }
            _previousPins = pins;
        }

        public int Score()
        {
            return _pinCount;
        }
    }
}