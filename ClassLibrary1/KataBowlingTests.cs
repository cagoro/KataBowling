using KataBowling;
using NUnit.Framework;

namespace KataBowlingTest
{
    [TestFixture]
    public class KataBowlingTests
    {
        [Test]
        public void NoScore()
        {
            var game = new Game();
            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }
            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void ScoreWithoutStrickesAndSpares()
        {
            var game = new Game();
            for (int i = 0; i < 20; i++)
            {
                game.Roll(4);
            }
            Assert.AreEqual(80, game.Score());
        }
        
        [Test]
        public void ScoreWithSpare()
        {
            var game = new Game();
            for (int i = 0; i < 10; i++)
            {
                game.Roll(2);
            }
            game.Roll(1);
            game.Roll(9);
            for (int i = 12; i < 20; i++)
            {
                game.Roll(2);
            }
            Assert.AreEqual(48, game.Score());
        }  
      
        [Test]
        public void ScoreWithMultipleNotConsecutiveSpares()
        {
            var game = new Game();
            game.Roll(1);
            game.Roll(9);  
            for (int i = 2; i < 10; i++)
            {
                game.Roll(2);
            }    
            game.Roll(1);
            game.Roll(9);
            for (int i = 12; i < 20; i++)
            {
                game.Roll(2);
            }
            Assert.AreEqual(56, game.Score());
        }

        [Test]
        public void ScoreWithMultipleConsecutiveSpares()
        {
            var game = new Game();

            for (int i = 0; i < 8; i++)
            {
                game.Roll(2);
            }
            game.Roll(1);
            game.Roll(9);  
            game.Roll(1);
            game.Roll(9);
            for (int i = 12; i < 20; i++)
            {
                game.Roll(2);
            }
            Assert.AreEqual(55, game.Score());
        }
    }
}
