using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerSideValidation.Fields;

namespace ServerSideValidation.Test
{
    [TestClass]
    public class RuleCheckerTest
    {
        #region Required

        [TestMethod]
        public void WhenFieldIsRequired_ExpectFilledInputPassed()
        {
            var field = new FreeField("test") { Required = true };
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFieldIsRequired_ExpectEmptyInputFailed()
        {
            var field = new FreeField(string.Empty) {Required = true};
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFieldIsNotRequired_ExpectEmptyInputPassed()
        {
            var field = new FreeField(string.Empty);
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region MaxLength

        [TestMethod]
        public void WhenFieldMaxLengthIs6_ExpectInputWith6CharsPassed()
        {
            var field = new FreeField("123456"){MaxLength = 6};
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFieldMaxLengthIs6_ExpectInputWith7CharsFailed()
        {
            var field = new FreeField("1234567"){MaxLength = 6};
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region MinLength

        [TestMethod]
        public void WhenFieldMinLengthIs6_ExpectInputWith6CharsPassed()
        {
            var field = new FreeField("123456"){MinLength = 6};
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFieldMinLengthIs6_ExpectInputWith5CharsFailed()
        {
            var field = new FreeField("12345"){MinLength = 6};
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFieldMinLengthIs6_ExpectEmptyInputPassed()
        {
            var field = new FreeField(string.Empty){MinLength = 6};
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region EqualTo

        [TestMethod]
        public void WhenFieldEqualsToTestString_ExpectInputWithTestStringPassed()
        {
            var field = new FreeField("TestString") { EqualTo = "TestString" };
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFieldEqualsToTestString_ExpectInputWithTestString1Failed()
        {
            var field = new FreeField("TestString1") { EqualTo = "TestString" };
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFieldEqualsToTestString_ExpectEmptyInputPassed()
        {
            var field = new FreeField(string.Empty) { EqualTo = "TestString" };
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        #endregion
    }
}
