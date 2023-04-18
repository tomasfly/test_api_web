using TestProject1.Src.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public async Task SetupAsync()
        {


        }

        [Test]
        public async Task Test1Async()
        {
            // Logic to retrieve test data. Or data stored securely somewhere.
            var parameters = new Dictionary<string, string> {
                { "name", "Tomas Fleiderman Gonzalez" },
                { "email", "tomasf@miemail.com" },
                { "password", "asdasd123" }
            };
            var c = new Client();
            await c.GetRequest("https://practice.expandtesting.com/notes/api/users/register", parameters);
        }


        [Test]
        public async Task Test1SeleniumAsync()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://practice.expandtesting.com/notes/app");
            IWebElement btn = driver.FindElement(By.LinkText("Login"));
            Assert.True(btn.Displayed);
            driver.Quit();
        }
    }
}