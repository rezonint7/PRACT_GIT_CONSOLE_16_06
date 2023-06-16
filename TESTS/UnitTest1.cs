using GIT_CONSOLE.Classes;

namespace TESTS
{
    public class Tests
    {
        [SetUp]
        public void Setup ()
        {


        }
        [Test]


        public void Test1 ()
        {
            string input = "Ïğèâåò Åãîğ";
            string actual = Vagner.Encrypt(input);
            string expected = "Í×58ÓÏÓŞÑÔÎ";
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test2 ()
        {
            string input = "Ïğèâåò Åãîğ";
            string actual = Vagner.Encrypt(input);
            string expected = "Í×58ÓÏÓŞÑÔÎ";
            Assert.AreEqual(expected, actual);

        }




        [Test]
        public void Test3 ()
        {
            string input = "Ïğèâåò Åãîğ";
            string actual = Vagner.Decrypt(input);
            string expected = "ÑÉ×Æ1ÕÂÖßÈÒ";
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test4 ()
        {
            string input = "Ïğèâåò Åãîğ";
            string actual = Vagner.Decrypt(input);
            string expected = "ÑÉ×Æ1ÕÂÖßÈÒ";
            Assert.AreEqual(expected, actual);

        }










        //[Test]
        ////public void Test5 ()
        ////{
        ////    int key = 1;
        ////    string input = "Ïğèâåò Åãîğ";

        ////    string actual = Cesar.Crypt(input);

         


        ////    string expected = "ÑÉ×Æ1ÕÂÖßÈÒ";
        ////    Assert.AreEqual(expected, actual);

        ////}








    }
}