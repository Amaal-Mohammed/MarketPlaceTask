using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Marketplacetask.pages;
using Marketplacetask.TestData;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Marketplacetask.Tests
{
    class Gist : Helpers.TestBase
    {
       // public IWebDriver driver;
        public IWebElement element;
        ChromeOptions options;
        ExtentHtmlReporter r1;
        AventStack.ExtentReports.ExtentReports extent;
        ExtentTest test;
        [OneTimeSetUp] 
        public void StartTC()
        {
            String reportpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" + "testresults.html";
            r1 = new ExtentHtmlReporter(reportpath);
            extent = new ExtentReports();
            extent.AttachReporter(r1);
            extent.AddSystemInfo("Opering System", "Windows 10");
            setUp("Chrome");
            driver.Url = "https://gist.github.com/discover";
            String datafilepath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" + Constants.filename;
            ReadData.setData(datafilepath);


        }


        [Test, Order(1)]
        public void githubGistWebTest()
        {
            LoginPage LoginP = new LoginPage(this.driver);
            DiscoverGistPage DiscoverP = new DiscoverGistPage(this.driver);
            AddGistPage AddgistP = new AddGistPage(this.driver);
            test = extent.CreateTest("Gist");
            DiscoverP.getSignIn().Click();
            LoginP.getUserName().SendKeys(ReadData.Email);
            LoginP.getPassword().SendKeys(ReadData.Password);
            LoginP.getLoginButton().Click();
            DiscoverP.getGithubIcon().Click();

            test.Log(Status.Info, "Log in User");

            AddgistP.getDescription().SendKeys(ReadData.Description);

            AddgistP.getFileExtension().SendKeys(ReadData.FileExtention);

            AddgistP.getFileExtension().SendKeys(Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab + ReadData.Content);

            AddgistP.getselectGist().Click();
            AddgistP.getCreatePublicGistoption().Click();
            AddgistP.getCreatePublicGistBtn().Click();

            test.Log(Status.Info, "Add Gist");

            AddgistP.getEditGist().Click();


            AddgistP.getAddFile().Click();
            AddgistP.getFileExtension().SendKeys(ReadData.FileExtention2);

            AddgistP.getLastfileExtension().SendKeys(Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab + ReadData.Content2);
            test.Log(Status.Info, "Edit Gist");
            AddgistP.getCommentBtn().Click();          
            AddgistP.getCommentField().SendKeys(ReadData.Comment1);
            AddgistP.getCommentBtn().Click();
            Thread.Sleep(2000);
            AddgistP.getCommentField().Click();
            AddgistP.getCommentField().SendKeys(ReadData.Comment2);
            AddgistP.getCommentBtn2().Click();

            test.Log(Status.Info, "Add two Comments");
            AddgistP.getLastComment().Click();

            AddgistP.getdeleteCommentsbtn().Click();

            AddgistP.confirmDeleionAlert();
            test.Log(Status.Info, "Delete Last Comment");
      

        }

        [TearDown]
        public void DerivedTearDown()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                   ? ""
                   : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;

            switch (status)
            {
                case NUnit.Framework.Interfaces.TestStatus.Failed:
                    logstatus = Status.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default:
                    logstatus = Status.Pass;
                    break;
            }

            test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
        }
        [OneTimeTearDown]
        public void endTest()
        {
            extent.Flush();
        }


    }
}
