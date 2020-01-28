using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Testing.Pages
{
   public class BasePage
    {
        public IWebDriver Driver { get; }
        
        public BasePage(IWebDriver driver) {
            Driver = driver; 
        
        }
    }
}
