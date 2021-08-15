using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAldoRoldan
{
    public class Test_002 : Test_00
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
            IWebElement btnElements = browserdriver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[1]"));
            btnElements.Click();
            Thread.Sleep(2000);
            IWebElement textbox = browserdriver.FindElement(By.Id("item-2"));
            textbox.Click();
            Thread.Sleep(1000);
                   
            IWebElement radiobutton = browserdriver.FindElement(By.Id("yesRadio"));

            IJavaScriptExecutor ex = (IJavaScriptExecutor)browserdriver;
            ex.ExecuteScript("arguments[0].click();", radiobutton);

            //radiobutton.Click();
            IWebElement radiobname = browserdriver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div[2]/div[1]/div[2]/label"));
            IWebElement txtoutradiobutton = browserdriver.FindElement(By.ClassName("text-success"));

            if (radiobname.Text == txtoutradiobutton.Text)
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
