using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerSideValidation.Fields;

namespace ServerSideValidation.Test
{
    [TestClass]
    public class PatternCheckerTest
    {
        #region Letter

        [TestMethod]
        public void WhenLetterFieldInitialized_ExpectOnlyLetterInputPassed()
        {
            var field = new LetterField("Test");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenLetterFieldInitialized_ExpectInputWithDigitFailed()
        {
            var field = new LetterField("Test123");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenLetterFieldInitialized_ExpectInputWithNonLetterCharsFailed()
        {
            var field = new LetterField("Test@");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenLetterFieldInitialized_ExpectEmptyInputPassed()
        {
            var field = new LetterField(string.Empty);
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region Digit

        [TestMethod]
        public void WhenDigitFieldInitialized_ExpectOnlyDigitInputPassed()
        {
            var field = new DigitField("123467890");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenDigitFieldInitialized_ExpectInputWithLetterFailed()
        {
            var field = new DigitField("Test123");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenDigitFieldInitialized_ExpectInputWithNonLetterCharsFailed()
        {
            var field = new DigitField("123@");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenDigitFieldInitialized_ExpectEmptyInputPassed()
        {
            var field = new DigitField(string.Empty);
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region AlphaNumeric

        [TestMethod]
        public void WhenAlphaNumericFieldInitialized_ExpectDigitAndLetterInputPassed()
        {
            var field = new AlphanumericField("123467890Test");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenAlphaNumericFieldInitialized_ExpectInputWithNonLetterCharsFailed()
        {
            var field = new AlphanumericField("123Test@");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenAlphaNumericFieldInitialized_ExpectEmptyInputPassed()
        {
            var field = new AlphanumericField(string.Empty);
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region NoTag

        [TestMethod]
        public void WhenNoTagFieldInitialized_ExpectNoTagInputPassed()
        {
            var field = new NoTagField("123467890Test$@");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenNoTagFieldInitialized_ExpectOnlyOpenTagInputPassed()
        {
            var field = new NoTagField("<test>123467890Test$@");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenNoTagFieldInitialized_ExpectOnlyClosingTagInputPassed()
        {
            var field = new NoTagField("123467890Test$@</test>");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenNoTagFieldInitialized_ExpectClosingTagMissmatchInputPassed()
        {
            var field = new NoTagField("<test>123467890Test$@</test1>");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenNoTagFieldInitialized_ExpectWithTagInputFailed()
        {
            var field = new NoTagField("<test>123467890Test$@</test>");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenNoTagFieldInitialized_ExpectEmptyInputPassed()
        {
            var field = new NoTagField(string.Empty);
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region Phone

        [TestMethod]
        public void WhenPhoneFieldInitialized_ExpectPhoneInputPassed()
        {
            var field = new PhoneField("05554443322");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenPhoneFieldInitialized_ExpectPhoneWithBlankInputPassed()
        {
            var field = new PhoneField("0555 444 33 22");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenPhoneFieldInitialized_ExpectPhoneWithSeperatorInputPassed()
        {
            var field = new PhoneField("0555-444-33-22");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenPhoneFieldInitialized_ExpectPhoneWithParanthesisInputPassed()
        {
            var field = new PhoneField("0(555)4443322");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenPhoneFieldInitialized_ExpectPhoneWithParanthesisAndBlankInputPassed()
        {
            var field = new PhoneField("0(555) 444 33 22");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenPhoneFieldInitialized_ExpectPhoneWithParanthesisAndSeparatorInputPassed()
        {
            var field = new PhoneField("0(555) 444-33-22");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenPhoneFieldInitialized_ExpectPhoneWithCountryCodeAndParanthesisAndSeparatorInputPassed()
        {
            var field = new PhoneField("+90 (555) 444-33-22");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenPhoneFieldInitialized_ExpectPhoneWithSeparatorAndWithoutAreaCodeInputPassed()
        {
            var field = new PhoneField("444-3-222");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenPhoneFieldInitialized_ExpectInputWithLetterFailed()
        {
            var field = new PhoneField("+90 (555) 444-3a-22");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenPhoneFieldInitialized_ExpectInputWithInsufficientFailed()
        {
            var field = new PhoneField("444322");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenPhoneFieldInitialized_ExpectInputWithExtraDigitFailed1()
        {
            var field = new PhoneField("44433221");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenPhoneFieldInitialized_ExpectInputWithExtraDigitFailed2()
        {
            var field = new PhoneField("55544433221");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region Email

        [TestMethod]
        public void WhenEmailFieldInitialized_ExpectEmailInputPassed1()
        {
            var field = new EmailField("Test@test.com");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenEmailFieldInitialized_ExpectEmailInputPassed2()
        {
            var field = new EmailField("test1@test1.net");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenEmailFieldInitialized_ExpectEmailInputPassed3()
        {
            var field = new EmailField("test1@test1.org");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenEmailFieldInitialized_ExpectEmailInputPassed4()
        {
            var field = new EmailField("test1@test1.co");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenEmailFieldInitialized_ExpectEmailInputPassed5()
        {
            var field = new EmailField("test1@test1.com.tr");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenEmailFieldInitialized_ExpectInputWithNonLetterCharsFailed()
        {
            var field = new EmailField("test1!@test1.com");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenEmailFieldInitialized_ExpectInputWithMissingFieldFailed1()
        {
            var field = new EmailField("@test1.com");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenEmailFieldInitialized_ExpectInputWithMissingFieldFailed2()
        {
            var field = new EmailField("test@.com");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenEmailFieldInitialized_ExpectInputWithMissingFieldFailed3()
        {
            var field = new EmailField("test@test");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region Float

        [TestMethod]
        public void WhenFloatFieldInitialized_ExpectFloatInputPassed1()
        {
            Global.CultureInfo = new CultureInfo("tr-TR");
            var field = new FloatField("15,3");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFloatFieldInitialized_ExpectFloatInputPassed2()
        {
            Global.CultureInfo = new CultureInfo("en-US");
            var field = new EmailField("15.3");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFloatFieldInitialized_ExpectFloatInputPassed3()
        {
            var field = new EmailField("15");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFloatFieldInitialized_ExpectFloatInputPassed4()
        {
            var field = new EmailField("0.15");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFloatFieldInitialized_ExpectFloatInputPassed5()
        {
            var field = new EmailField("-0.15");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFloatFieldInitializedWithCultureTR_ExpectInputWithDotFailed()
        {
            Global.CultureInfo = new CultureInfo("tr-TR");
            var field = new EmailField("15.3");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFloatFieldInitializedEn_ExpectInputWithCommaFailed()
        {
            Global.CultureInfo = new CultureInfo("en-US");
            var field = new EmailField("15,3");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenFloatFieldInitializedEn_ExpectInputWithNonNumericCharFailed()
        {
            var field = new EmailField("15.3a");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region URL

        [TestMethod]
        public void WhenUrlFieldInitialized_ExpectUrlInputPassed1()
        {
            var field = new UrlField("http://www.test.com");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenUrlFieldInitialized_ExpectUrlInputPassed2()
        {
            var field = new UrlField("http://test.com");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenUrlFieldInitialized_ExpectUrlInputPassed3()
        {
            var field = new UrlField("http://test.com/test.aspx");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenUrlFieldInitialized_ExpectUrlInputPassed4()
        {
            var field = new UrlField("http://www.test.k12.tr");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenUrlFieldInitialized_ExpectInputWithNonEnglishCharsFailed()
        {
            var field = new UrlField("http://www.testış.com");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenUrlFieldInitialized_ExpectInputWithNonUrlCharsFailed()
        {
            var field = new UrlField("http://www.test+.com");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region URL Friendly

        [TestMethod]
        public void WhenUrlFriendlyFieldInitialized_ExpectUrlFriendlyInputPassed1()
        {
            var field = new UrlFriendlyField("test");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenUrlFriendlyFieldInitialized_ExpectUrlFriendlyInputPassed2()
        {
            var field = new UrlFriendlyField("test-Test");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenUrlFriendlyFieldInitialized_ExpectUrlFriendlyInputPassed3()
        {
            var field = new UrlFriendlyField("test-Test?test=Test");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenUrlFriendlyFieldInitialized_ExpectInputWithNonEnglishCharsFailed()
        {
            var field = new UrlFriendlyField("ş");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenUrlFriendlyFieldInitialized_ExpectInputWithNonUrlCharsFailed()
        {
            var field = new UrlFriendlyField("!");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region Custom

        [TestMethod]
        public void WhenCustomFieldInitialized_ExpectInputFitInPatternPassed()
        {
            var field = new CustomField("tes(.)*$", "aatestbb123");
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenCustomFieldInitialized_ExpectInputNotFitInPatternFailed()
        {
            var field = new CustomField("tes(.)*$", "aatetbb123");
            var expected = false;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WhenCustomFieldInitialized_ExpectEmptyInputPassed()
        {
            var field = new CustomField("tes(.)*$", string.Empty);
            var expected = true;
            var result = field.ValidateField();

            Assert.AreEqual(expected, result);
        }

        #endregion
    }
}