using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using System.Diagnostics;

namespace TestCalc
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow("text_a", true)]
        [DataRow("text_b", true)]
        [DataRow("text_op", true)]
        [DataRow("text_res", true)]
        public void Calc_EnableTxt(string id, bool exp)
        {
            Application application = Application.Launch(new ProcessStartInfo(@"CalcWinForm.exe")
            {
                WorkingDirectory = @"..\..\..\CalcWinForm\bin\Debug\",
            });
            Window window = application.GetWindows()[0];

            bool res = window.Get<TextBox>(SearchCriteria.ByAutomationId(id)).Enabled;
            Assert.AreEqual(exp, res);
            application.Kill();
        }

        [DataTestMethod]
        [DataRow("btn_res", true)]
        public void Calc_EnableBtn(string id, bool exp)
        {
            Application application = Application.Launch(new ProcessStartInfo(@"CalcWinForm.exe")
            {
                WorkingDirectory = @"..\..\..\CalcWinForm\bin\Debug\",
            });
            Window window = application.GetWindows()[0];

            bool res = window.Get<Button>(SearchCriteria.ByAutomationId(id)).Enabled;
            Assert.AreEqual(exp, res);
            application.Kill();
        }

        [DataTestMethod]
        [DataRow("5", "2", "+")]
        [DataRow("6", "3", "-")]
        [DataRow("7", "4", "*")]
        [DataRow("8", "1", "/")]
        public void Calc_SimpleCheck(string  a, string b, string op)
        {
            Application application = Application.Launch(new ProcessStartInfo(@"CalcWinForm.exe")
            {
                WorkingDirectory = @"..\..\..\CalcWinForm\bin\Debug\",
            });
            Window window = application.GetWindows()[0];
            
            window.Get<TextBox>(SearchCriteria.ByAutomationId("text_a")).SetValue(a);
            window.Get<TextBox>(SearchCriteria.ByAutomationId("text_b")).SetValue(b);
            window.Get<TextBox>(SearchCriteria.ByAutomationId("text_op")).SetValue(op);

            string resA = window.Get<TextBox>(SearchCriteria.ByAutomationId("text_a")).Text;
            string resB = window.Get<TextBox>(SearchCriteria.ByAutomationId("text_b")).Text;
            string resOp = window.Get<TextBox>(SearchCriteria.ByAutomationId("text_op")).Text;

            Assert.AreEqual(a, resA);
            Assert.AreEqual(b, resB);
            Assert.AreEqual(op, resOp);

            application.Kill();
        }

        [DataTestMethod]
        [DataRow("52", "23")]
        [DataRow("611", "344")]
        [DataRow("7456", "4654")]
        [DataRow("82340", "10900")]
        public void Calc_ComplexCheck(string a, string b)
        {
            Application application = Application.Launch(new ProcessStartInfo(@"CalcWinForm.exe")
            {
                WorkingDirectory = @"..\..\..\CalcWinForm\bin\Debug\",
            });
            Window window = application.GetWindows()[0];

            window.Get<TextBox>(SearchCriteria.ByAutomationId("text_a")).SetValue(a);
            window.Get<TextBox>(SearchCriteria.ByAutomationId("text_b")).SetValue(b);

            string resA = window.Get<TextBox>(SearchCriteria.ByAutomationId("text_a")).Text;
            string resB = window.Get<TextBox>(SearchCriteria.ByAutomationId("text_b")).Text;

            Assert.AreEqual(a, resA);
            Assert.AreEqual(b, resB);

            application.Kill();
        }

        [DataTestMethod]
        [DataRow("11", "7", "p", "18")]
        [DataRow("14", "3", "-", "11")]
        [DataRow("15", "6", "*", "90")]
        [DataRow("80", "20", "/", "4")]
        public void Calc_RealJob(string a, string b, string op, string exp)
        {
            Application application = Application.Launch(new ProcessStartInfo(@"CalcWinForm.exe")
            {
                WorkingDirectory = @"..\..\..\CalcWinForm\bin\Debug\",
            });
            Window window = application.GetWindows()[0];

            window.Get<TextBox>(SearchCriteria.ByAutomationId("text_a")).SetValue(a);
            window.Get<TextBox>(SearchCriteria.ByAutomationId("text_b")).SetValue(b);
            window.Get<TextBox>(SearchCriteria.ByAutomationId("text_op")).SetValue(op);
            window.Get<Button>(SearchCriteria.ByAutomationId("btn_res")).Click();
            string res = window.Get<TextBox>(SearchCriteria.ByAutomationId("text_res")).Text;
            Assert.AreEqual(exp, res);
            application.Kill();
        }
    }


}
