using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
namespace TestingDevNetss.Core
{
    public class DriverContext
    {
        WebDriver driver;
        public WebDriver StartDriver(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    driver=new ChromeDriver();
                    break;
                case "Edge":
                    driver=new EdgeDriver();
                    break;
            }
            return driver;
        }
    }
}
