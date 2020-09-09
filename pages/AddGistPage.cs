using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplacetask.pages
{
    class AddGistPage
    {
        IWebDriver driver;
        public AddGistPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement getDescription()
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//main[1]//form[1]/div[1]/div[1]/input[1]")));

            IWebElement description = driver.FindElement(By.XPath("//main[1]//form[1]/div[1]/div[1]/input[1]"));
            return description;
        }

        public IWebElement getFileExtension()
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@placeholder='Filename including extension…']")));

            IWebElement fileext = driver.FindElement(By.XPath("//input[@placeholder='Filename including extension…']"));
            return fileext;
        }

        public IWebElement getselectGist()
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//summary[@class='btn btn-primary BtnGroup-item select-menu-button float-none']")));
            IWebElement selgist = driver.FindElement(By.XPath("//summary[@class='btn btn-primary BtnGroup-item select-menu-button float-none']"));
            return selgist;
        }

        public IWebElement getCreatePublicGistoption()
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='select-menu-item-heading'][contains(text(),'Create public gist')]")));
            IWebElement createpublicgistgist = driver.FindElement(By.XPath("//span[@class='select-menu-item-heading'][contains(text(),'Create public gist')]"));
            return createpublicgistgist;
        }

        public IWebElement getCreatePublicGistBtn()
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@class='btn btn-primary BtnGroup-item hx_create-pr-button js-sync-select-menu-button']")));
            IWebElement createpublicgistgist = driver.FindElement(By.XPath("//button[@class='btn btn-primary BtnGroup-item hx_create-pr-button js-sync-select-menu-button']"));
            return createpublicgistgist;
        }
        public IWebElement getEditGist()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement editgist = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//main[1]//ul[1]/li[1]/a[1]")));
            return editgist;
        }

        public IWebElement getAddFile()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement addfilegist = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[@class='btn float-left js-add-gist-file']")));
            return addfilegist;
        }

        public IWebElement getLastfileExtension()
        {
            ReadOnlyCollection<IWebElement> filesext = driver.FindElements(By.XPath("//input[@placeholder='Filename including extension…']"));
            var x = filesext[filesext.Count - 1];
            return x;
        }

        public IWebElement getCommentBtn()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement commentfield = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[contains(@class,'btn btn-primary')]")));
            return commentfield;
        }

        public IWebElement getCommentField()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement commentfield = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("new_comment_field")));
            return commentfield;
        }

        public IWebElement getCommentBtn2()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement commentbtn2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[contains(text(),'Comment')]")));
            return commentbtn2;
        }
     
        public IWebElement getLastComment()
        {
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement comments = wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//main[1]//div[2]/div[2]/div[2]//summary[1]")));
            return comments;
        }
        public IWebElement getdeleteCommentsbtn()
        {
            ReadOnlyCollection<IWebElement> delcomments = driver.FindElements(By.XPath("//button[@aria-label='Delete comment']"));
            var dellastcomment = delcomments[delcomments.Count - 1]; ;
            return dellastcomment;
        }

        public int getCommentCount()
        {
            ReadOnlyCollection<IWebElement> delcomments = driver.FindElements(By.XPath("//button[@aria-label='Delete comment']"));
            var commentcount = delcomments.Count ;
            return commentcount;
        }
        public void confirmDeleionAlert()
        {
            var confirm_win = driver.SwitchTo().Alert();
            confirm_win.Accept();
        }
   
    }
}
