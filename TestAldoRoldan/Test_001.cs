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
    public class Test_001
    {
        IWebDriver browserdriver = new ChromeDriver("C:\\Users\\home\\source\\repos\\TestAldoRoldan");
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
            IWebElement textbox = browserdriver.FindElement(By.Id("item-0"));
            textbox.Click();
            Thread.Sleep(1000);

            IWebElement txtFullName = browserdriver.FindElement(By.Id("userName"));
            txtFullName.SendKeys("Juan Perez");
            IWebElement txtEmail = browserdriver.FindElement(By.Id("userEmail"));
            txtEmail.SendKeys("juanp@gmail.com");
            IWebElement txtCurrentAdres = browserdriver.FindElement(By.Id("currentAddress"));
            txtCurrentAdres.SendKeys("San José, Costa rica");
            IWebElement txtPermanentAdress = browserdriver.FindElement(By.Id("permanentAddress"));
            txtPermanentAdress.SendKeys("San José");
            IWebElement btnSubmit = browserdriver.FindElement(By.Id("submit"));
            btnSubmit.Click();
            Thread.Sleep(2000);

            IWebElement txtoutname = browserdriver.FindElement(By.Id("name"));

            if (txtoutname.Text == "Name: Juan Perez")
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
