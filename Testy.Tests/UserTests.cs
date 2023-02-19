
using Klasy;

namespace Testy.Tests
{
    public class Tests
    {
        [Test]
        public void ScoreSumUser1()
        {
            // arange
            var user1 = new User("Seba", "Mas³o1");
            user1.AddScore(5);
            user1.AddScore(4);
            user1.AddScore(-1);
            user1.AddScore(-4);

            // act
            var result1 = user1.Result;

            // assert
            Assert.AreEqual(4, result1);
        }

        [Test]
        public void ScoreSumUser2()
        {
            // arrange

            var user2 = new User("Szymon", "Mas³o2");
            user2.AddScore(2);
            user2.AddScore(4);
            user2.AddScore(3);
            user2.AddScore(9);
            user2.AddScore(-13);

            // act
            var result2 = user2.Result;

            // assert
            Assert.AreEqual(5, result2);

        }
    }
}