using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using System.Diagnostics;
using NUnit.Framework;
using Microsoft.AspNetCore.Components.Web;
using OpenQA.Selenium.DevTools.V101.Network;
using System.Threading;

namespace SeleniumFramework.util
{
    class Util
    {
        private IWebDriver driver = null;
        public Util(IWebDriver d)
        {
            driver = d;
        }
        public void captureScreenshot(string testName)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string screenShotDir = workingDirectory + "\\screenshots";
            bool exists = System.IO.Directory.Exists(screenShotDir);
            if (!exists)
                System.IO.Directory.CreateDirectory(screenShotDir);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string screenshot = ss.AsBase64EncodedString;
            byte[] screenshotAsByteArray = ss.AsByteArray;
            string imageFilePath = screenShotDir + "\\" + testName + "_" + GetTimestamp(DateTime.Now) + ".png";
            ss.SaveAsFile(imageFilePath, OpenQA.Selenium.ScreenshotImageFormat.Png);
            TestContext.AddTestAttachment(imageFilePath);
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        public IWebElement WaitForElementVisible(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30) );
            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            return element;
        }

        public bool SendKeysToDropDown(By locator , string value)
        {
            bool returnValue = false;
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                returnValue = true;
            }
            catch (NoSuchElementException e)
            {
                TestContext.WriteLine("Element " + locator + "not found on page " + driver.Title);
                returnValue = false;
            }
            catch (Exception e)
            {
                TestContext.WriteLine("Unknown error " + e.Message + " occurred on page " + driver.Title);
                returnValue = false;
            }
            return returnValue;
        }


        public bool SendKeys(By locator , string value)
        {
            bool returnValue = false;
            try
            {
                WaitForElementVisible(locator).SendKeys(value);
                
                returnValue = true;
            }
            catch (NoSuchElementException e)
            {
                TestContext.WriteLine("Element " + locator + "not found on page " + driver.Title);
                returnValue = false;
            }
            catch (Exception e)
            {
                TestContext.WriteLine("Unknown error " + e.Message + " occurred on page " + driver.Title);
                returnValue = false;
            }
            return returnValue;
        }
        public bool ClickElement(By locator)
        {
            bool returnValue = false;
            try
            {
                WaitForElementVisible(locator).Click();
                returnValue = true;
            }
            catch (NoSuchElementException e)
            {
                TestContext.WriteLine("Element " + locator + "not found on page " + driver.Title);
                returnValue = false;
            }
            catch (Exception e)
            {
                TestContext.WriteLine("Unknown error " + e.Message + " occurred on page " + driver.Title);
                returnValue = false;
            }
            return returnValue;
        }


        public bool IsElementVisible(By locator)
        {
            bool returnValue = false;
            try
            {
                returnValue=WaitForElementVisible(locator).Displayed;
            }
            catch (NoSuchElementException e)
            {
                TestContext.WriteLine("Element " + locator + "not found on page " + driver.Title);
                returnValue=false;
            }
            catch (Exception e)
            {
                TestContext.WriteLine("Unknown error " + e.Message + " occurred on page " + driver.Title);
                returnValue = false;
            }
            return returnValue;
        }
    }
}
