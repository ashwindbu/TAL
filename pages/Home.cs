using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumFramework.util;
namespace SeleniumFramework.pages
{
    class Home
    {
        //########## Setup ############
        private IWebDriver driver = null;
        private Util util = null;
        public Home(IWebDriver d)
        {
            this.driver = d;
            util = new Util(d);
        }
        //########### Element Definition #############
        private By getprestaShop = By.CssSelector(".popup-link.prestashop-link.primary-link");
        private By resourceMenuXpath = By.XPath("//*[@id='header-menu']/div[1]/ul/li[2]/span");

        //Insurance
        private By insuranceMenuXpath = By.XPath("//*[@id=\"nav\"]/ul/li[2]/a");
        private By lifeInsuranceMenuXpath = By.XPath("//*[@id=\"nav\"]/ul/li[2]/div/div/ul/li[3]/a");
        private By lifeInsuranceGetAQuote = By.XPath("//*[@id=\"home-banner\"]/div/div/div/div[2]/a");
        private By lifeInsuranceDOB = By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[3]/div/div/div[2]/div/div[2]/div[2]/div[1]/main/div/div/div/div/div[2]/div[2]/form/div[1]/div[2]/div/input");
        private By lifeInsuranceGender = By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[3]/div/div/div[2]/div/div[2]/div[2]/div[1]/main/div/div/div/div/div[2]/div[2]/form/div[2]/div[2]/div/div/div[1]/div");
        private By lifeInsuranceSmoke = By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[3]/div/div/div[2]/div/div[2]/div[2]/div[1]/main/div/div/div/div/div[2]/div[2]/form/div[3]/div[2]/div/div/div[2]/div/label");
        private By lifeInsuranceOccupation = By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[3]/div/div/div[2]/div/div[2]/div[2]/div[1]/main/div/div/div/div/div[2]/div[2]/form/div[4]/div[2]/div/div/input");
        private By lifeInsuranceEmployed = By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[3]/div/div/div[2]/div/div[2]/div[2]/div[1]/main/div/div/div/div/div[2]/div[2]/form/div[5]/div/div/div/div/div/label/span");
        private By lifeInsuranceAnnualIncome = By.XPath("//*[@id=\"main-content-container\"]/div/div[3]/div/div/div[2]/div/div[2]/div[2]/div[1]/main/div/div/div/div/div[2]/div[2]/form/div[4]/div[2]/div/div");
        private By lifeInsuranceGetAQuoteContinue1 = By.XPath("//*[@id=\"main-content-container\"]/div/div[3]/div/div/div[2]/div/div[2]/div[2]/div[1]/main/div/div/div/div/div[2]/div[2]/form/div[7]/div/button");
        private By lifeInsuranceHomePage = By.XPath("//*[@id=\"main-content-container\"]/div/div[3]/div/div/div[2]/div/div[2]/div[2]/div[1]/main/div/div/div/div/div[2]/div[1]/div[2]/div/h2");

        private By lifeInsuranceFirstName = By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[3]/div/div/div[2]/div/div[2]/div[2]/div[1]/main/div/div/div/div/div[2]/div[2]/form/div[2]/div[2]/div/input");
        private By lifeInsuranceLastName = By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[3]/div/div/div[2]/div/div[2]/div[2]/div[1]/main/div/div/div/div/div[2]/div[2]/form/div[3]/div[2]/div/input");
        private By lifeInsurancePhone = By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[3]/div/div/div[2]/div/div[2]/div[2]/div[1]/main/div/div/div/div/div[2]/div[2]/form/div[4]/div[2]/div/input");
        private By lifeInsuranceEmail = By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[3]/div/div/div[2]/div/div[2]/div[2]/div[1]/main/div/div/div/div/div[2]/div[2]/form/div[5]/div[2]/div/input");
        private By lifeInsurancePostCode = By.XPath("/html/body/div[1]/div/main/div/div/div/div/div[3]/div/div/div[2]/div/div[2]/div[2]/div[1]/main/div/div/div/div/div[2]/div[2]/form/div[6]/div[2]/div/input");

        private By lifeInsuranceCalculateMyQuote = By.XPath("//*[@id=\"main-content-container\"]/div/div[3]/div/div/div[2]/div/div[2]/div[2]/div[1]/main/div/div/div/div/div[2]/div[2]/form/div[8]/div/button");
        private By lifeInsuranceAddLifeInsurancePlan = By.XPath("//*[@id=\"LI\"]/div/div/div[2]/button");

        private By lifeInsuranceCoverAmountText = By.XPath("/html/body/div/div/main/div/div/div/div/div/div[3]/div/div/div[2]/div/div[2]/div/div[1]/main/div/div/div/div[4]/div/div/div/div[2]/div[2]/div[4]/div/form/div[2]/div/div/div[2]/div/div/div/div/input");


        private By featureMenuXpath = By.XPath("//*[@id='header-menu']//a[contains(text(),'Features')]");
        //######### Function Definition #################
        public bool isHomePageLoaded()
        {
            return util.IsElementVisible(getprestaShop);
        }
        public bool clickResourceMenu()
        {
            return util.ClickElement(resourceMenuXpath);
        }
        public bool clickInsuranceMenu()
        {
            return util.ClickElement(insuranceMenuXpath);
        }

        public bool clickLifeInsuranceMenu()
        {
            return util.ClickElement(lifeInsuranceMenuXpath);
        }

        public bool clickLifeInsuranceGetAQuote()
        {
            return util.ClickElement(lifeInsuranceGetAQuote);
        }

        public bool clickLifeInsuranceDOB()
        {
            return util.ClickElement(lifeInsuranceDOB);
        }

        public bool enterLifeInsuranceDOB(string dob)
        {
            return util.SendKeys(lifeInsuranceDOB , dob);
        }

        public bool clickLifeInsuranceGender()
        {
            return util.ClickElement(lifeInsuranceGender);
        }

        public bool clickLifeInsuranceSmoke()
        {
            return util.ClickElement(lifeInsuranceSmoke);
        }

        public bool selectLifeInsuranceOccupation(string value)
        {
            //return util.SelectElementFromDropDown(lifeInsuranceOccupation , value);
            return util.SendKeysToDropDown(lifeInsuranceOccupation, value);
        }

        public bool clickLifeInsuranceSelfEmployed()
        {
            return util.ClickElement(lifeInsuranceEmployed);
        }

        public bool enterLifeInsuranceAnnualIncome(string value)
        {
            //return util.SelectElementFromDropDown(lifeInsuranceOccupation , value);
            return util.SendKeys(lifeInsuranceAnnualIncome, value);
        }

        public bool clickLifeInsuranceHomeButton()
        {
            return util.ClickElement(lifeInsuranceHomePage);
        }

        public bool clickLifeInsuranceDOBContinue()
        {
            return util.ClickElement(lifeInsuranceGetAQuoteContinue1);
        }

        public bool clickFeatureMenu()
        {
            return util.ClickElement(featureMenuXpath);
        }
        public void openHome(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.FullScreen();
            util.captureScreenshot("openHome");
        }
    }
}
