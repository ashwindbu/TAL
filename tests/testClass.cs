using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumFramework.util;
using System.Runtime;
using SeleniumFramework.pages;
using FluentAssertions;
namespace SeleniumFramework.tests
{
    [TestFixture]

    class testClass
    {
        IWebDriver driver = null;
        GettingStarted gettingStarted = null;
        Home home = null;
        TestDataManager testData = null;
        DriverManager dm = new DriverManager();
        public static void Main(string[] args)
        {
            Console.WriteLine("Main");
        }
        [OneTimeSetUp]
        public void initialize()
        {
            testData = TestDataManager.GetInstance;
            driver = dm.getDriver(testData.browserConfig);
            gettingStarted = new GettingStarted(driver);
            home = new Home(driver);
        }

        [Test]
        public void Flow2()
        {
            home.openHome(testData.AppURL);
            TestContext.WriteLine("App is launched successfully");
            home.clickInsuranceMenu().Should().BeTrue();
            home.clickLifeInsuranceMenu().Should().BeTrue();
            home.clickLifeInsuranceGetAQuote().Should().BeTrue();
            home.clickLifeInsuranceDOB().Should().BeTrue();
            home.enterLifeInsuranceDOB("02071989").Should().BeTrue();
            home.clickLifeInsuranceGender().Should().BeTrue();
            home.clickLifeInsuranceSmoke().Should().BeTrue();
            home.selectLifeInsuranceOccupation("Account Executive");
            home.clickLifeInsuranceSelfEmployed().Should().BeTrue();
            home.enterLifeInsuranceAnnualIncome("10000").Should().BeTrue();
            home.clickLifeInsuranceDOBContinue().Should().BeTrue();

        }

        [OneTimeTearDown]
        public void cleanUp()
        {
            driver.Quit();
        }
    }
}
