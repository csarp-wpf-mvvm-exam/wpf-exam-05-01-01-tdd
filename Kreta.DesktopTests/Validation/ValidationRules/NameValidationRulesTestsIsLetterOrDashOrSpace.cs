using Kreta.Desktop.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MenuProject.Validation.ValidationRules.Tests
{
    [TestClass()]
    public class NameValidationRulesTestsIsLetterOrDashOrSpace
    {
        [TestMethod()]
        public void NameValidationRulesTestEmpty()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("");
            // act
            bool actual = nvr.IsLetterOrDashOrSpace;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestValidShortName()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Fa");
            // act
            bool actual = nvr.IsLetterOrDashOrSpace;
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestValidLongName()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Farkas");
            // act
            bool actual = nvr.IsLetterOrDashOrSpace;
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestNotValidDashedName()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("F-rkas");
            // act
            bool actual = nvr.IsLetterOrDashOrSpace;
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestValidSpacedName()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Farkasné Balogh");
            // act
            bool actual = nvr.IsLetterOrDashOrSpace;
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestNotValidScpacedName()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("F rkas");
            // act
            bool actual = nvr.IsLetterOrDashOrSpace;
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestDigit()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("F8rkas");
            // act
            bool actual = nvr.IsLetterOrDashOrSpace;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestSpecialCharacter()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("F*rkas");
            // act
            bool actual = nvr.IsLetterOrDashOrSpace;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestNotValidOnlyCharcter()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("FaRkas");
            // act
            bool actual = nvr.IsLetterOrDashOrSpace;
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestValidGermanCharacter()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Fßrkas");
            // act
            bool actual = nvr.IsLetterOrDashOrSpace;
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestValidGreekCharacter()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Fαrkas");
            // act
            bool actual = nvr.IsLetterOrDashOrSpace;
            // assert
            Assert.IsTrue(actual);
        }
    }
}