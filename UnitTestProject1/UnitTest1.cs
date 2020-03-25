using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading;
using Excel;
using IpInfo.Api.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl("https://www.instagram.com/");

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/article/div[2]/div[1]/div/form/div[2]/div/label/input")).SendKeys("KULLANICIADI");
            driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/article/div[2]/div[1]/div/form/div[3]/div/label/input")).SendKeys("ŞİFRE");
            driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/article/div[2]/div[1]/div/form/div[4]/button/div")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/button[2]")).Click();
            driver.Navigate().GoToUrl("https://www.instagram.com/..../");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/div/header/section/ul/li[2]/a")).Click();
            Thread.Sleep(3000);
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]"));
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            for (int i = 0; i < 100; i++)
            {
                js.ExecuteScript("arguments[0].scrollTo(0, arguments[0].scrollHeight);return arguments[0].scrollHeight;", element);
                Thread.Sleep(2000);
            }
            for (int j = 1; j < 41; j++)
            {
                driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/ul/div/li[" + j + "]/div/div[2]/button")).Click();
                
            }
            Thread.Sleep(610000);
            for (int k = 41; k < 81; k++)
            {
                driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/ul/div/li[" + k + "]/div/div[2]/button")).Click();
            }
            Thread.Sleep(610000);
            for (int l = 81; l < 121; l++)
            {
                driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/ul/div/li[" + l + "]/div/div[2]/button")).Click();
            }
        }
    }
}
