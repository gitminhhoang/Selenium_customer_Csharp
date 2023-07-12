using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_custom.controller
{
    public class Selenium_connect_port
    {
        public ChromeDriver ConnectDriver(int port)
        {
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.DebuggerAddress = $"127.0.0.1:{port}";

                FileInfo gpmDriverFileInfo = new FileInfo("chromedriver.exe");
                ChromeDriverService service = ChromeDriverService.CreateDefaultService(gpmDriverFileInfo.DirectoryName, gpmDriverFileInfo.Name);
                service.HideCommandPromptWindow = true;

                ChromeDriver driver = new ChromeDriver(service, options);

                return driver;
            }catch(Exception ex)
            {
                return null;
            }
        }
        public void GotoUrl(ChromeDriver driver, string url)
        {
            driver.Url = url;
        }
        public void GoBack(ChromeDriver driver)
        {
            driver.Navigate().Back();
        }
        public IWebElement findElementXpath(ChromeDriver driver, string element)
        {
            IWebElement find = driver.FindElement(By.XPath(element));
            return find;
        }
        public bool HasFindElementXpath(ChromeDriver driver, string element)
        {
            try
            {
                driver.FindElement(By.XPath(element));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public ReadOnlyCollection<IWebElement> findElementXpaths(ChromeDriver driver, string element)
        {
            var find = driver.FindElements(By.XPath(element));
            return find;
        }
        public IWebElement findElementSelector(ChromeDriver driver, string element)
        {
            IWebElement find = driver.FindElement(By.CssSelector(element));
            return find;
        }
        public bool HasFindElementSelector(ChromeDriver driver, string element)
        {
            try
            {
                driver.FindElement(By.CssSelector(element));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public ReadOnlyCollection<IWebElement> findElementSelectors(ChromeDriver driver, string element)
        {
            var find = driver.FindElements(By.CssSelector(element));
            return find;
        }
        public void ClickElement(IWebElement element)
        {
            element.Click();
        }
        public void ClickElement(ChromeDriver driver, string element, string type)
        {
            if (type == "xpath")
            {
                driver.FindElement(By.XPath(element)).Click();
            }
            else
            {
                driver.FindElement(By.CssSelector(element)).Click();
            }
        }
        public void EnterElement(IWebElement element)
        {
            element.SendKeys(OpenQA.Selenium.Keys.Enter);
        }
        public void QuitBrowser(ChromeDriver driver)
        {
            driver.Quit();
        }
        public void SendText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }
        public string GetText(IWebElement element)
        {
            return element.Text;
        }
        public string GetText(ChromeDriver driver, string element, string type)
        {
            string value = "";
            if (type == "xpath")
            {
                value = driver.FindElement(By.XPath(element)).Text;
            }
            else
            {
                value = driver.FindElement(By.CssSelector(element)).Text;
            }
            return value;
        }
    }
}
