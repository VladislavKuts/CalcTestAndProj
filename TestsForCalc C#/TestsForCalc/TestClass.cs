// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation

using NUnit.Framework;
using OpenQA.Selenium.Winium;

namespace TestsForCalc
{
    [TestFixture]
    public class TestClass_Plus_Minus_Umn_Del
    {
        DesktopOptions options = new DesktopOptions();
        WiniumDriver app;


        [SetUp]
        public void OpenApp()
        {
            options.ApplicationPath = @"C:\Users\kutsv\source\repos\TestsForCalc\Calculate.exe"; //путь к калькулятору
            app = new WiniumDriver(@"C:\Users\kutsv\source\repos\TestsForCalc", options);  //путь к winium.exe с точностью до папки
        }

        [Test]
        public void TC01_Plus()
        {

            app.FindElementById("bNum9").Click();
            app.FindElementById("bNum1").Click();
            app.FindElementById("bPlus").Click();
            app.FindElementById("bNum1").Click();
            app.FindElementById("bNum8").Click();
            app.FindElementById("bRavno").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "109");
            app.Quit();
        }



        [Test]
        public void TC02_Minus()
        {
            app.FindElementById("bNum5").Click();
            app.FindElementById("bNum3").Click();
            app.FindElementById("bMinus").Click();
            app.FindElementById("bNum3").Click();
            app.FindElementById("bNum4").Click();
            app.FindElementById("bRavno").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "19");
            app.Quit();
        }

        [Test]
        public void TC03_Umn()
        {
            app.FindElementById("bNum2").Click();
            app.FindElementById("bNum1").Click();
            app.FindElementById("bUmn").Click();
            app.FindElementById("bNum5").Click();
            app.FindElementById("bNum3").Click();
            app.FindElementById("bRavno").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "1113");
            app.Quit();
        }

        [Test]
        public void TC04_Umn()
        {
            app.FindElementById("bNum4").Click();
            app.FindElementById("bNum5").Click();
            app.FindElementById("bUmn").Click();
            app.FindElementById("bNum2").Click();
            app.FindElementById("bNum3").Click();
            app.FindElementById("bRavno").Click();
            app.FindElementById("BKSP").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "103");
            app.Quit();
        }

        [Test]
        public void TC05_Delenie()
        {
            app.FindElementById("bNum1").Click();
            app.FindElementById("bNum0").Click();
            app.FindElementById("bNum0").Click();
            app.FindElementById("bDelenie").Click();
            app.FindElementById("bNum1").Click();
            app.FindElementById("bNum0").Click();
            app.FindElementById("bRavno").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "10");
            app.Quit();
        }

        [Test]
        public void TC06_Delenie()
        {
            app.FindElementById("bNum1").Click();
            app.FindElementById("bNum0").Click();
            app.FindElementById("bNum0").Click();
            app.FindElementById("bNum0").Click();
            app.FindElementById("BKSP").Click();
            app.FindElementById("bDelenie").Click();
            app.FindElementById("bNum1").Click();
            app.FindElementById("bNum0").Click();
            app.FindElementById("bRavno").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "10");
            app.Quit();
        }

        [Test]
        public void TC07_Delenie()
        {
            app.FindElementById("bNum5").Click();
            app.FindElementById("bNum6").Click();
            app.FindElementById("bNum1").Click();
            app.FindElementById("bNum3").Click();
            app.FindElementById("bClear").Click();
            app.FindElementById("bNum1").Click();
            app.FindElementById("bNum0").Click();
            app.FindElementById("bNum0").Click();
            app.FindElementById("bDelenie").Click();
            app.FindElementById("bNum1").Click();
            app.FindElementById("bNum0").Click();
            app.FindElementById("bRavno").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "10");
            app.Quit();
        }

    }



    [TestFixture]
    public class TestClass_Clear_Drob
    {
        DesktopOptions options = new DesktopOptions();
        WiniumDriver app;


        [SetUp]
        public void OpenApp()
        {
            options.ApplicationPath = @"C:\Users\kutsv\source\repos\TestsForCalc\Calculate.exe"; //путь к калькулятору
            app = new WiniumDriver(@"C:\Users\kutsv\source\repos\TestsForCalc", options);  //путь к winium.exe с точностью до папки
        }



        [Test]
        public void TC08_Clear()
        {
            app.FindElementById("bNum2").Click();
            app.FindElementById("bNum3").Click();
            app.FindElementById("bNum4").Click();
            app.FindElementById("tb_Calc").Click();
            app.FindElementById("BKSP").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "23");
            app.Quit();
        }

        [Test]
        public void TC09_Clear()
        {
            app.FindElementById("bNum2").Click();
            app.FindElementById("bNum3").Click();
            app.FindElementById("bNum4").Click();
            app.FindElementById("bNum5").Click();
            app.FindElementById("bNum6").Click();
            app.FindElementById("bNum7").Click();
            app.FindElementById("bClear").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "0");
            app.Quit();
        }


        [Test]
        public void TC10_DeleniyByZero()
        {
            app.FindElementById("bNum0").Click();
            app.FindElementById("bDelenie").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "Division by zero");
            app.Quit();
        }

        [Test]
        public void TC11_DelenieByZero()
        {
            app.FindElementById("bNum2").Click();
            app.FindElementById("bDelenie").Click();
            app.FindElementById("bNum0").Click();
            app.FindElementById("bRavno").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "∞");
            app.Quit();
        }

        [Test]
        public void TC12_Drobnie()
        {
            app.FindElementById("bNum9").Click();
            app.FindElementById("bPoint").Click();
            app.FindElementById("bNum2").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "9,2");
            app.Quit();

        }

        [Test]
        public void TC13_Drobnie()
        {
            app.FindElementById("bNum3").Click();
            app.FindElementById("bPoint").Click();
            app.FindElementById("bNum5").Click();
            app.FindElementById("bPoint").Click();
            app.FindElementById("bNum7").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "3,57");
            app.Quit();

        }

        [Test]
        public void TC14_Drobnie()
        {
            app.FindElementById("bPoint").Click();
            app.FindElementById("bNum2").Click();
            app.FindElementById("bPoint").Click();
            app.FindElementById("bNum1").Click();
            app.FindElementById("bPoint").Click();
            app.FindElementById("bNum5").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "0,215");
            app.Quit();

        }


        [Test]
        public void TC15_Stability()
        {
            app.FindElementById("bNum9").Click();
            app.FindElementById("bPlus").Click();
            app.FindElementById("bNum9").Click();
            app.FindElementById("bMinus").Click();
            app.FindElementById("bNum2").Click();
            app.FindElementById("bUmn").Click();
            app.FindElementById("bNum5").Click();
            app.FindElementById("bDelenie").Click();
            app.FindElementById("bNum4").Click();
            app.FindElementById("bRavno").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "20");
            app.Quit();

        }

        [Test]
        public void TC16_Ravno()
        {
            app.FindElementById("bNum1").Click();
            app.FindElementById("bRavno").Click();
            Assert.AreEqual(app.FindElementById("tb_Calc").Text, "0");
            app.Quit();

        }
    }
}


