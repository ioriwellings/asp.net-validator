using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerSideValidation.Fields;

namespace ServerSideValidation.Test
{
    [TestClass]
    public class MessagesTest
    {
        #region Pattern Errors

        [TestMethod]
        public void WhenLetterPatternFailed_ExpectLetterPatternMessageShown()
        {
            var field = new LetterField("123");
            field.ValidateField();
            var expected = Global.ResourceManager.GetString("letter", Global.CultureInfo);
            var result = field.Error;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenDigitPatternFailed_ExpectDigitPatternMessageShown()
        {
            var field = new DigitField("test");
            field.ValidateField();
            var expected = Global.ResourceManager.GetString("digits", Global.CultureInfo);
            var result = field.Error;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenAlphaNumericPatternFailed_ExpectAlphaNumericPatternMessageShown()
        {
            var field = new AlphanumericField("test@");
            field.ValidateField();
            var expected = Global.ResourceManager.GetString("alphanumeric", Global.CultureInfo);
            var result = field.Error;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenNoTagPatternFailed_ExpectNoTagPatternMessageShown()
        {
            var field = new NoTagField("<test>test</test>");
            field.ValidateField();
            var expected = Global.ResourceManager.GetString("noTag", Global.CultureInfo);
            var result = field.Error;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenPhonePatternFailed_ExpectPhonePatternMessageShown()
        {
            var field = new PhoneField("test");
            field.ValidateField();
            var expected = Global.ResourceManager.GetString("phone", Global.CultureInfo);
            var result = field.Error;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenEmailPatternFailed_ExpectEmailPatternMessageShown()
        {
            var field = new EmailField("test");
            field.ValidateField();
            var expected = Global.ResourceManager.GetString("email", Global.CultureInfo);
            var result = field.Error;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenUrlPatternFailed_ExpectUrlPatternMessageShown()
        {
            var field = new UrlField("test test");
            field.ValidateField();
            var expected = Global.ResourceManager.GetString("url", Global.CultureInfo);
            var result = field.Error;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenUrlFriendlyPatternFailed_ExpectUrlFriendlyPatternMessageShown()
        {
            var field = new UrlFriendlyField("test test");
            field.ValidateField();
            var expected = Global.ResourceManager.GetString("urlFriendly", Global.CultureInfo);
            var result = field.Error;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenCustomPatternFailed_ExpectCustomPatternMessageShown()
        {
            var field = new CustomField(@"\d", "test");
            field.ValidateField();
            var expected = Global.ResourceManager.GetString("custom", Global.CultureInfo);
            var result = field.Error;

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region Rule Errors

        [TestMethod]
        public void WhenFieldRequired_ExpectRequiredMessageShown()
        {
            var field = new FreeField(string.Empty){Required = true};
            field.ValidateField();
            var expected = Global.ResourceManager.GetString("required", Global.CultureInfo);
            var result = field.Error;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFieldHasMaxLengthError_ExpectMaxLengthMessageShown()
        {
            var field = new FreeField("123456"){MaxLength = 5};
            field.ValidateField();
            var expected = Global.ResourceManager.GetString("maxLength", Global.CultureInfo);
            var result = field.Error;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFieldHasMinLengthError_ExpectMinLengthMessageShown()
        {
            var field = new FreeField("123456"){MinLength = 7};
            field.ValidateField();
            var expected = Global.ResourceManager.GetString("minLength", Global.CultureInfo);
            var result = field.Error;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFieldHasEqualityError_ExpectEqualMessageShown()
        {
            var field = new FreeField("123456"){EqualTo = "test"};
            field.ValidateField();
            var expected = Global.ResourceManager.GetString("equal", Global.CultureInfo);
            var result = field.Error;

            Assert.AreEqual(expected, result);
        }

        #endregion
    }
}