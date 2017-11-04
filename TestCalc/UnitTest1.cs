using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;

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
        public void Calc_Enable(string id, bool exp)
        {
            Application application = Application.Launch(@"D:\COURSE\СЕРВЕРА\TEAM\CalcWinForm\CalcWinForm\bin\Debug\CalcWinForm.exe");
            Window window = application.GetWindows()[0];

            bool res = window.Get<TextBox>(SearchCriteria.ByAutomationId(id)).Enabled;
            Assert.AreEqual(exp, res);
            application.Kill();
        }
    }
}
