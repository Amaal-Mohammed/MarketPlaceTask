using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplacetask.pages
{
    class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement getUserName()
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_field")));
          
            IWebElement username = driver.FindElement(By.Id("login_field"));
            return username;
        }
        public IWebElement getPassword()
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));

            IWebElement password = driver.FindElement(By.Id("password"));
            return password;
        }

        public IWebElement getLoginButton()
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("commit")));
            IWebElement loginbtn = driver.FindElement(By.Name("commit"));
            return loginbtn;
        }


    }
}
