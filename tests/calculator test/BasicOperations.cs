namespace calculator_test
{
    public class Tests
    {
        calc_lib.BasicOperations _op;
        [SetUp]
        public void Setup() => _op = new calc_lib.BasicOperations();


        //[Test]
        //public void Summ_A_And_B_Equals_ResultTest()
        //{
        //   var summ= _op.Summ(5, 5);
        //    Assert.That(summ, Is.EqualTo (10));
        //}
        [Test]
        public void Raznost_A_And_B_Equals_ResultTest()
        {
            var raznost = _op.Raznost(5, 5);
            Assert.That(raznost, Is.EqualTo(0));
        }
        [TestCase(5,5,10)]
        [TestCase(6, 4, 11)]
        [TestCase(5, 5, 0)]
        public void Raznost_A_And_B_Equals_ResultTest(int a,int b,int result)
        {
            var raznost = _op.Raznost(a, b);
            Assert.That(raznost, Is.EqualTo(result));
        }
    }
}