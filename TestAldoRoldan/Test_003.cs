using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAldoRoldan
{
    public class Test_003 : Test_00
    {               
        IWebDriver browserdriver = new ChromeDriver(GetPath());
        [SetUp]
        public void OpenBrowser()
        {                       
            browserdriver.Navigate().GoToUrl("https://demoqa.com/");
            Thread.Sleep(2000);
            browserdriver.Manage().Window.Maximize();

        }

        [Test]
        public void ExecuteSteps()
        {           
            IWebElement btnalertsframeW = browserdriver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[3]"));
            btnalertsframeW.Click();
            Thread.Sleep(2000);
            IWebElement btnalert = browserdriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[3]/div/ul/li[2]"));
            btnalert.Click();
            Thread.Sleep(1000);

            IWebElement btnpromptbutton = browserdriver.FindElement(By.Id("promtButton"));
            btnpromptbutton.Click();

            var alert_win = browserdriver.SwitchTo().Alert();
            alert_win.SendKeys("Aldo Roldan");
            alert_win.Accept();

            IWebElement lbloutname = browserdriver.FindElement(By.Id("promptResult"));

            if (lbloutname.Text == "Aldo Roldan")
            {
                Console.Write("Éxito");
            }
            else
            {
                Console.Write("Fallo");
            }

        }

        [TearDown]
        public void EndTest()
        {           
            //close the browser  
            browserdriver.Close();
        }

    }
}
