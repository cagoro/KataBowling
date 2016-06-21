namespace KataBowling
{
    public class Game
    {
        private int _pinCount;
        private bool _wasThereASpare;
        private int _previousPins;
        private bool _isAFirstShot;
        private bool _wasThereAStrike;

        public Game()
        {
            _isAFirstShot = true;
        }

        public void Roll(int pins)
        {
            if (_isAFirstShot)
            {
                if (_wasThereAStrike)
                {
                    _pinCount += pins * 2;
                }
                _wasThereAStrike = (pins == 10);
                if (_wasThereASpare)
                {
                    _pinCount += pins * 2;
                    _wasThereASpare = false;
                }
                else
                {
                    _pinCount += pins;
                }
                _isAFirstShot = _wasThereAStrike;
            }
            else
            {
                if (_wasThereAStrike)
                {
                    _pinCount += pins * 2;
                    _wasThereAStrike = false;
                }
                else
                {
                    _pinCount += pins;
                }
                _wasThereASpare = _previousPins + pins == 10;
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