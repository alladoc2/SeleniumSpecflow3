using Automation.Testing.Pages;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.Testing.StepDef
{
    [Binding]
    public class GenericStepDef
    {
        private IWebDriver driver;
        private readonly IObjectContainer objectContainer;

        public GenericStepDef(IObjectContainer  cointainer) {
            this.objectContainer = cointainer;

        }
        [BeforeScenario]
        public void InitializingDriver() {
            this.driver = new ChromeDriver();  // FirefoxDriver();  
            objectContainer.RegisterInstanceAs<ILogin>(new LoginPage(this.driver));
            objectContainer.RegisterInstanceAs<IWebDriver>(this.driver);

            this.driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void closeDriver() {
            this.driver.Close();
        }
    }
}
