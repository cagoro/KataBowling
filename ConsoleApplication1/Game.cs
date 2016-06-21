namespace KataBowling
{
    public class Game
    {
        private int _pinCount;

        public void Roll(int pins)
        {
            _pinCount += pins;
        }

        public int Score()
        {
            return _pinCount;
        }
    }
}