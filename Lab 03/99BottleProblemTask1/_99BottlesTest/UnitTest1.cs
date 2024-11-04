
namespace _99BottlesTest
{
    public class Tests
    {
        Bottles _bottles;

        [SetUp]
        public void Setup()
        {
            _bottles = new Bottles();
        }

        /*
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        */

        [Test]
        public void test_a_verse()
        {
            String expected = "99 bottles of beer on the wall, 99 bottles of beer.\n" +
                              " Take one down and pass it around, 98 bottles of beer on the wall.\n";
            Assert.AreEqual(expected, _bottles.verse(99));
        }

        [Test]
        public void test_another_verse()
        {
            String expected = "89 bottles of beer on the wall, 89 bottles of beer.\n" +
                              " Take one down and pass it around, 88 bottles of beer on the wall.\n";
            Assert.AreEqual(expected, _bottles.verse(89));
        }
    }
}
