using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Training8.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        public ChromeDriver driver;
        public FirefoxDriver driverFirefox;
        public InternetExplorerDriver driverIE;

        [BeforeScenario]
        public void BeforeScenario()
        {
               //chromeDriver driver = new ChromeDriver();
               //driver = new Chromedriver();

            //driverFirefox = FirefoxDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
