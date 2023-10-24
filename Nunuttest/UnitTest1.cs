using newconsole;

namespace Nunuttest
{
    public class Tests
    {
        private BasicMaths _bm { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _bm = new BasicMaths();
        }

        [Test]
        public void Test1()
        {
            var x = 1;
            var y = 2;
            var z = _bm.Add(x, y);
            Assert.That(3, Is.EqualTo(z));
        }
    }
}