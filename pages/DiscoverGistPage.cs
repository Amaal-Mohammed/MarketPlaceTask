using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplacetask.pages
{
    class DiscoverGistPage
    {
        IWebDriver driver;
        public DiscoverGistPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement getGithubIcon()
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[local-name()='svg'][2]/*[name()='path'][1]")));

            IWebElement githubgist = driver.FindElement(By.XPath("//*[local-name()='svg'][2]/*[name()='path'][1]"));
            return githubgist;
        }

        public IWebElement getSignIn()
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[1]/div[5]/a[1]")));
            IWebElement signbtn= driver.FindElement(By.XPath("//div[1]/div[5]/a[1]"));
            return signbtn;
        }
    }
}
