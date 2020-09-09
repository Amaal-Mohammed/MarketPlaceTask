using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Marketplacetask.Helpers
{
    class TestBase
    {
        protected IWebDriver driver;
        ChromeOptions options;
        public void setUp(String browsername)
        {
            if (browsername == "Chrome")
            {
                options = new ChromeOptions();
                String driverpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                options.AddArguments("--disable-notifications");
                options.AddArgument("no-sandbox");
                options.AddArgument("--incognito");
                TimeSpan T1 = new TimeSpan(0, 0, 30);
                driver = new ChromeDriver(driverpath, options, T1);
            }

            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
        }

       
    }
}
